import React, { useState } from "react";
import { makeStyles, Theme, createStyles } from "@material-ui/core/styles";
import ListSubheader from "@material-ui/core/ListSubheader";
import List from "@material-ui/core/List";
import ListItem from "@material-ui/core/ListItem";
import ListItemText from "@material-ui/core/ListItemText";
import Collapse from "@material-ui/core/Collapse";
import ExpandLess from "@material-ui/icons/ExpandLess";
import ExpandMore from "@material-ui/icons/ExpandMore";
import Checkbox from "@material-ui/core/Checkbox";
import Divider from "@material-ui/core/Divider";
import TextField from "@material-ui/core/TextField";
import { IconButton } from "@material-ui/core";
import CheckIcon from '@material-ui/icons/Check';
import SaveIcon from '@material-ui/icons/Save';
import InputLabel from '@material-ui/core/InputLabel';
import Select from '@material-ui/core/Select';
import { display } from "@material-ui/system";

const useStyles = makeStyles((theme: Theme) =>
    createStyles({
        root: {
            width: "100%",
            maxWidth: 360,
            backgroundColor: theme.palette.background.paper
        },
        nested: {
            paddingLeft: theme.spacing(4)
        },
        div: {
            whiteSpace: "nowrap",
        }
    })
);

function ListComponent(label: string, shouldExpand: any, open: boolean, handleClick: any) : JSX.Element {
    const classes = useStyles();

    return (
        <div>
            <ListItem id={`${label}`} className={shouldExpand ? classes.root : classes.nested} button onClick={(e) => { return (shouldExpand ? handleClick() : null) }}>
                <Checkbox id = {`Checkbox ${label}`} onClick={(e) => e.stopPropagation()} />
                <ListItemText primary={`${label}`} />
                {shouldExpand
                    ? (open ? <ExpandLess /> : <ExpandMore />)
                    : null}
            </ListItem>
            {shouldExpand ? <Divider /> : null}
        </div >
    );
};

function GetChildComponent(i: number, props: any, open: boolean, handleClick: any) {
    const membersArray: any = Object.values(props.treePickerInput);
    const newMemberArray = membersArray[i].map((member: any) => ListComponent(member, false, open = false, handleClick = () => { }))

    return newMemberArray;
}

const getListComponents = (inputLength: number, props: any) => {
    const arrayToShow: any = [];

    for (let i = 0; i < inputLength; i++) {
        arrayToShow.push(getParentComponent(i, props))
    }

    return arrayToShow;
}

const getParentComponent = (i: number, props: any) => Object.keys(props.treePickerInput).filter((team, index) => index === i).map((team) => {
    const [open, setOpen] = React.useState(false);
    const [check, setAllChecked] = React.useState(false);

    const checkAll = () => {
        let parentCheckbox = document.getElementById(`Checkbox TeamA`);

    }

    const handleClick = () => {
        setOpen(!open);
    };

    return (
        <div key={i}>
            {ListComponent(team, true, open, handleClick)}
            < Divider />
            <Collapse in={open} timeout="auto" unmountOnExit>
                <List component="div" disablePadding>
                    {GetChildComponent(i, props, open, handleClick)}
                </List>
            </Collapse>
        </div>
    )
});

function InitializeActionButtons() {
    const classes = useStyles();
    return (
        <div className={classes.div}>
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


export default function InitializeComponents(props: any): JSX.Element {
    const classes = useStyles();
    let inputLength = Object.keys(props.treePickerInput).length;

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
                    className={classes.root}
                >
                    {getListComponents(inputLength, props)}
                </List>
            </div >
            <div>
                    {InitializeActionButtons()}
            </div>
        </div>
    )
}
