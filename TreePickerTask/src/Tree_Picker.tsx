import React from "react";
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

export default function NestedList() {
  const classes = useStyles();
  const [open, setOpen] = React.useState(true);

  const handleClick = () => {
    setOpen(!open);
  };

  return (
    <List
      component="nav"
      aria-labelledby="nested-list-subheader"
      subheader={
        <ListSubheader component="div" id="nested-list-subheader">
          Teams/Search
        </ListSubheader>
      }
      className={classes.root}
    >
      <ListItem button onClick={handleClick}>
        <ListItemIcon>
          <Checkbox />
        </ListItemIcon>
        <ListItemText primary="Team A" />
        {open ? <ExpandLess /> : <ExpandMore />}
      </ListItem>
      <Divider/>
      <Collapse in={open} timeout="auto" unmountOnExit>
        <List component="div" disablePadding>
          <ListItem button className={classes.nested}>
            <ListItemIcon>
              <Checkbox />
            </ListItemIcon>
            <ListItemText primary="Pesho" />
          </ListItem>
          <ListItem button className={classes.nested}>
            <ListItemIcon>
              <Checkbox />
            </ListItemIcon>
            <ListItemText primary="Kolyo" />
          </ListItem>
          <ListItem button className={classes.nested}>
            <ListItemIcon>
              <Checkbox />
            </ListItemIcon>
            <ListItemText primary="Stavri" />
          </ListItem>
        </List>
      </Collapse>
      <ListItem button onClick={handleClick}>
        <ListItemIcon>
          <Checkbox />
        </ListItemIcon>
        <ListItemText primary="Team B" />
        {open ? <ExpandLess /> : <ExpandMore />}
      </ListItem>
      <Collapse in={open} timeout="auto" unmountOnExit>
        <List component="div" disablePadding>
          <ListItem button className={classes.nested}>
            <ListItemIcon>
              <Checkbox />
            </ListItemIcon>
            <ListItemText primary="Pankaj" />
          </ListItem>
          <ListItem button className={classes.nested}>
            <ListItemIcon>
              <Checkbox />
            </ListItemIcon>
            <ListItemText primary="Ali" />
          </ListItem>
        </List>
      </Collapse>
      <ListItem button onClick={handleClick}>
        <ListItemIcon>
          <Checkbox />
        </ListItemIcon>
        <ListItemText primary="Team C" />
        {open ? <ExpandLess /> : <ExpandMore />}
      </ListItem>
      <Collapse in={open} timeout="auto" unmountOnExit>
        <List component="div" disablePadding>
          <ListItem button className={classes.nested}>
            <ListItemIcon>
              <Checkbox />
            </ListItemIcon>
            <ListItemText primary="Gururaj" />
          </ListItem>
          <ListItem button className={classes.nested}>
            <ListItemIcon>
              <Checkbox />
            </ListItemIcon>
            <ListItemText primary="Kamal" />
          </ListItem>
        </List>
      </Collapse>
    </List>
  );
}
