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

const expanded =
{
    TeamA: false,
    TeamB: true
};

export default function TreePicker() {
    const classes = useStyles();
    const [open1, setOpen1] = React.useState(false);
    const [open2, setOpen2] = React.useState(false);
    const [open3, setOpen3] = React.useState(false);

    const handleClick1 = () => {
        setOpen1(!open1);
    };

    const handleClick2 = () => {
        setOpen2(!open2);
    };

    const handleClick3 = () => {
        setOpen3(!open3);
    };
    return (
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
            <ListItem button onClick={handleClick1}>
                <Checkbox onClick={e => e.stopPropagation()} />
                <ListItemText id='TeamA' primary="Team A" />
                {open1 ? <ExpandLess /> : <ExpandMore />}
            </ListItem>
            <Divider />
            <Collapse in={open1} timeout="auto" unmountOnExit>
                <List component="div" disablePadding>
                    <ListItem className={classes.nested}>
                        <Checkbox />
                        <ListItemText primary="Pesho" />
                    </ListItem>
                    <ListItem className={classes.nested}>
                            <Checkbox />
                        <ListItemText primary="Kolyo" />
                    </ListItem>
                    <ListItem className={classes.nested}>
                        <Checkbox />
                        <ListItemText primary="Stavri" />
                    </ListItem>
                </List>
            </Collapse>
            <ListItem button onClick={handleClick2}>
                <Checkbox onClick={e => e.stopPropagation()} />
                <ListItemText id='TeamB' primary="Team B" />
                {open2 ? <ExpandLess /> : <ExpandMore />}
            </ListItem>
            <Divider />
            <Collapse in={open2} timeout="auto" unmountOnExit>
                <List component="div" disablePadding>
                    <ListItem className={classes.nested}>
                        <Checkbox />
                        <ListItemText primary="Pankaj" />
                    </ListItem>
                    <ListItem className={classes.nested}>
                        <Checkbox />
                        <ListItemText primary="Ali" />
                    </ListItem>
                </List>
            </Collapse>

            <ListItem button onClick={handleClick3}>
                <Checkbox onClick={e => e.stopPropagation()} />
                <ListItemText id='TeamC' primary="Team C" />
                {open3 ? <ExpandLess /> : <ExpandMore />}
            </ListItem>
            <Divider />
            <Collapse in={open3} timeout="auto" unmountOnExit>
                <List component="div" disablePadding>
                    <ListItem className={classes.nested}>
                        <Checkbox />
                        <ListItemText primary="Gururaj" />
                    </ListItem>
                    <ListItem className={classes.nested}>
                        <Checkbox />
                        <ListItemText primary="Kamal" />
                    </ListItem>
                </List>
            </Collapse>
        </List>
    );
}
