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

const listComponent = (classes: any, handleClick: any, label: string, shouldExpand: any, open = false) => {
    return (
        <div>
            <ListItem id={`${label}`} className={shouldExpand ? classes.root : classes.nested} onClick={shouldExpand? handleClick : null}>
                <Checkbox />
                <ListItemText primary={`${label}`} />
                {shouldExpand
                    ? (open ? <ExpandLess /> : <ExpandMore />)
                    : null}
            </ListItem>
            {shouldExpand ? <Divider/> : null}
        </div >
    );
}


export default function InitializeComponents(props: any): JSX.Element {
    const classes = useStyles();
    const [open, setOpen] = React.useState(false);

    const handleClick = () => {
        setOpen(!open);
    };

    const getParentComponent = () => Object.keys(props.treePickerInput).map((team) => listComponent(classes, handleClick, team, true));

    const getChildComponent = () => Object.values(props.treePickerInput).map((membersArray: any) => membersArray.forEach((currentMember: any) => currentMember = listComponent(classes, handleClick, currentMember, false)))

    const getParentChildElement = (i: number) => {
        return (
            <div>
                {getParentComponent()[i]}
                <Divider />
                <Collapse in={open} timeout="auto" unmountOnExit>
                    <List component="div" disablePadding>
                        {getChildComponent()[i]}
                    </List>
                </Collapse>
            </div>
        )
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
                {getParentChildElement(0)}
                {getParentChildElement(1)}
                {getParentChildElement(2)}
            </List>
        </div >
    )
}
