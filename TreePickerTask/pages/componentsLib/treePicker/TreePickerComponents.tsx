import React, { useState } from "react";
import { makeStyles, Theme, createStyles } from "@material-ui/core/styles";
import ListSubheader from "@material-ui/core/ListSubheader";
import List from "@material-ui/core/List";
import ListItem from "@material-ui/core/ListItem";
import ListItemIcon from "@material-ui/core/ListItemIcon";
import ListItemText from "@material-ui/core/ListItemText";
import Collapse from "@material-ui/core/Collapse";
import ExpandLess from "@material-ui/icons/ExpandLess";
import ExpandMore from "@material-ui/icons/ExpandMore";
import Checkbox from "@material-ui/core/Checkbox";
import Divider from "@material-ui/core/Divider";
import TextField from "@material-ui/core/TextField";
import { Button } from "@material-ui/core";

type TreePickerComponentsProps = {
    treePickerInput: any
}

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

const listComponent = (classes: any, id: string, handleClick: any, label: string, shouldExpand: any, open = false) => {
    return (
        <div>
            <ListItem id={id} className={classes.nested} onClick={handleClick}>
                <Checkbox />
                <ListItemText primary={`${label}`} />
                {shouldExpand
                    ? (open ? <ExpandLess /> : <ExpandMore />)
                    : null}
            </ListItem>
        </div >
    );
}


const groupComponent = (getChildComponents: any) => {
    return (
        <Collapse in={open} timeout="auto" unmountOnExit>
            <List component="div" disablePadding>
               {getChildComponents()}
            </List>
        </Collapse>
    )
}

export default function InitializeComponents(props: any): JSX.Element {
    let keyNames = Object.keys(props.treePickerInput)
    let valueArrays = Object.values(props.treePickerInput);
    type valueArrays = any;

    const [open, setOpen] = React.useState(false);

    const handleClick = () => {
        setOpen(!open);
    };

    const classes = useStyles();

    let component: any;
    let currentValue: any;

    const getListComponents = () => {
        const components = []
        for (let currentKey in keyNames.values) {
            components.push(listComponent(classes, currentKey, handleClick, currentKey, true))
            for (currentValue of valueArrays) {
                for (let childComponent of currentValue) {
                    components.push(listComponent(classes, childComponent, handleClick, childComponent, false));
                }
            }
        }

        return components;
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
                {listComponent(classes, 'TeamA', handleClick, 'TeamA', true)}
                <Divider />
                <Collapse in={open} timeout="auto" unmountOnExit>
                    <List component="div" disablePadding>
                        {getListComponents()}
                    </List>
                </Collapse>
                {listComponent(classes, 'TeamB', handleClick, 'TeamB', true)}
                <Divider />
                {groupComponent(getListComponents)}
                {listComponent(classes, 'TeamC', handleClick, 'TeamC', true)}
                <Divider />
                <Collapse in={open} timeout="auto" unmountOnExit>
                    <List component="div" disablePadding>
                        {listComponent(classes, 'Gururaj', handleClick, 'Gururaj', false, open)}
                        {listComponent(classes, 'Kamal', handleClick, 'Kamal', false, open)}
                    </List>
                </Collapse>
            </List>
        </div >
    )
}
