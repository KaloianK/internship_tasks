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

const useStyles = makeStyles((theme: Theme) =>
    createStyles({
        root: {
            width: "100%",
            maxWidth: 360,
            backgroundColor: theme.palette.background.paper
        },
        nested: {
            paddingLeft: theme.spacing(4)
        }
    })
);



export default function InitializeComponents(props: any): JSX.Element {
    const classes = useStyles();
    const [open, setOpen] = React.useState(false);
    let inputLength = Object.keys(props.treePickerInput).length;

    const handleClick = () => {
        setOpen(!open);
    };

    const listComponent = (label: string, shouldExpand: any) => {
        return (
            <div>
                <ListItem id={`${label}`} className={shouldExpand ? classes.root : classes.nested} button onClick={(e) => { return (shouldExpand ? handleClick() : null) }}>
                    <Checkbox onClick={(e) => e.stopPropagation()} />
                    <ListItemText primary={`${label}`} />
                    {shouldExpand
                        ? (open ? <ExpandLess /> : <ExpandMore />)
                        : null}
                </ListItem>
                {shouldExpand ? <Divider /> : null}
            </div >
        );
    };

    const getParentComponent = (i: number) => Object.keys(props.treePickerInput).filter((team, index) => index === i).map((team) => {
        return (
            // eslint-disable-next-line react/jsx-key
            <div>
                {listComponent(team, true)}
                < Divider />
                <Collapse in={open} timeout="auto" unmountOnExit>
                    <List component="div" disablePadding>
                        {getChildComponent(i)}
                    </List>
                </Collapse>
            </div>
        )
    });

    const getChildComponent = (i: number) => {
        const membersArray: any = Object.values(props.treePickerInput);
        let newMemberArray = membersArray[i].map((member: any) => listComponent(member, false))

        return newMemberArray;
    }

    const getListComponents = (inputLength: number) => {
        let arrayToShow: any = [];

        for (let i = 0; i < inputLength; i++) {
            arrayToShow.push(getParentComponent(i))
        }

        return arrayToShow;
    }

    return (
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
                {getListComponents(inputLength)}

            </List>
        </div >
    )
}
