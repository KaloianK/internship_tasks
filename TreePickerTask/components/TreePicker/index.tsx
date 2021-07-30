import { Collapse, Divider, IconButton, InputLabel, List, ListSubheader, Select, TextField } from "@material-ui/core";
import { ExpandLess, ExpandMore } from "@material-ui/icons";
import CheckIcon from "@material-ui/icons/Check";
import SaveIcon from "@material-ui/icons/Save";
import React, { useEffect, useState } from "react";

function SingleComponent(shouldExpand: boolean, name: string, getCheckedForParent: any, open: any, componentState: any, getCheckedForChild: any, handleClick: any) {
    return (
        <div>
            {shouldExpand ? (
                <div>
                    <input
                        type='checkbox'
                        onChange={e => getCheckedForParent(e)}
                        onClick={(e) => e.stopPropagation()}
                    ></input>
                    <label>{name}</label>
                    {shouldExpand
                        ? (open ? <ExpandLess onClick={handleClick} /> : <ExpandMore onClick={handleClick} />)
                        : null}
                </div>) : (<div>
                    {componentState.map((currentMemberInfo: any, index: number) => (
                        <div key={index} onClick={(event) => MultiFunctionality(currentMemberInfo, event, getCheckedForChild)}>
                            <input
                                type='checkbox'
                                onChange={event => getCheckedForChild(event, currentMemberInfo)}
                                checked={currentMemberInfo.select}
                            ></input>
                            <label>{currentMemberInfo.name}</label>
                        </div>))}
                </div>)
            }
        </div>
    )
}

function MultiFunctionality(currentMemberInfo: any, event: any, getCheckedForChild: any) {
    getCheckedForChild(event, currentMemberInfo);
    event.stopPropagation()
}

function ParentChildComponent(teamName: string, props: any) {
    const [open, setOpen] = React.useState(false);

    const handleClick = () => {
        setOpen(!open);
    };

    const [componentState, setComponentState]: [{ [key: string]: any }, any] = useState([]);

    const getCheckedForParent = (e: any) => {
        let checked = e.target.checked;

        setComponentState(
            componentState.map((currentMemberInfo: any) => {
                currentMemberInfo.select = checked;

                return currentMemberInfo;
            })
        );
    };

    const getCheckedForChild = (event: any, currentMemberInfo: any) => {
        let checked = event.target.checked;

        setComponentState(
            componentState.map((info: any) => {
                if (currentMemberInfo.guid === info.guid) {
                    info.select = checked;
                }

                return info;
            })
        );
    };

    useEffect(() => {
        let componentState: any = props.treePickerInput[teamName];

        setComponentState(
            componentState.map((currentMember: any) => {
                return {
                    select: false,
                    guid: currentMember.guid,
                    name: currentMember.name
                };
            })
        );
    }, []);

    return (
        <div>
            {SingleComponent(true, teamName, getCheckedForParent, open, componentState, getCheckedForChild, handleClick)}
            < Divider />
            <Collapse in={open} timeout="auto" unmountOnExit>
                <List component="div" disablePadding>
                    {SingleComponent(false, teamName, getCheckedForParent, open, componentState, getCheckedForChild, handleClick)}
                </List>
            </Collapse>
        </div>
    );
}

function InitializeActionButtons() {
    return (
        <div>
            <IconButton id={'Done Button'} onClick={() => alert('Cheese +')}>
                <CheckIcon />
            </IconButton>
            <IconButton id={'Save Button'} onClick={() => alert('Watermelon')}>
                <SaveIcon />
            </IconButton>
            <InputLabel htmlFor="grouped-native-select">My Saved</InputLabel>
            <Select native defaultValue="" id="Teams">
                <optgroup label="TeamA">
                    <option value={1}>Pesho</option>
                    <option value={2}>Kolyo</option>
                    <option value={3}>Stavri</option>
                </optgroup>
                <optgroup label="TeamB">
                    <option value={4}>Pankaj</option>
                    <option value={5}>Ali</option>
                </optgroup>
                <optgroup label="TeamC">
                    <option value={6}>Gururaj</option>
                    <option value={6}>Kamal</option>
                </optgroup>
            </Select>
        </div>
    )
}

function TreePicker(props: any): JSX.Element {
    const getFullTree = () => {
        return Object.keys(props.treePickerInput).map((currentTeamName: string) => ParentChildComponent(currentTeamName, props));
    }

    return (
        <div>
            <div>
                <List
                    component="nav"
                    aria-labelledby="nested-list-subheader"
                    subheader={
                        <ListSubheader component="div" id="nested-list-subheader">
                            <TextField id="SearchField" label="Search" variant='outlined' />
                        </ListSubheader>
                    }
                >
                    {getFullTree()}
                </List>

            </div>
            <div>
                {InitializeActionButtons()}
            </div>
        </div>
    );
}

export default TreePicker;