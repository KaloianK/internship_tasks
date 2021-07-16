import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import TreeView from '@material-ui/lab/TreeView';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';
import ChevronRightIcon from '@material-ui/icons/ChevronRight';
import TreeItem from '@material-ui/lab/TreeItem';

class TreePicker extends React.Component {
    peopleInTeamA: string[];
    peopleInTeamB: string[];
    peopleInTeamC: string[];
    constructor(props: {} | Readonly<{}>) {
        super(props);

        this.peopleInTeamA = ['Pesho', 'Kolyo', 'Stavri'];
        this.peopleInTeamB = ['Pankaj', 'Ali'];
        this.peopleInTeamC = ['Gururaj', 'Kamal'];

        this.state = {
            TeamA: this.peopleInTeamA,
            TeamB: this.peopleInTeamB,
            TeamC: this.peopleInTeamC
        }
    }

    InitializeTreeView() {
            for (let value in Object.values(this.state)) {
                <TreeItem nodeId={value} label={value} />
            }
    }

    TreeView() {
        return (
            <TreeView
                
                defaultCollapseIcon={<ExpandMoreIcon />}
                defaultExpandIcon={<ChevronRightIcon />}
            >
                <TreeItem nodeId="Team A" label="Team A">
                    <TreeItem nodeId="Pesho" label="Pesho" />
                    <TreeItem nodeId="Kolyo" label="Kolyo" />
                    <TreeItem nodeId="Stavri" label="Stavri" />
                </TreeItem>
                <TreeItem nodeId="Team B" label="Team B">
                    <TreeItem nodeId="Pankaj" label="Pankaj" />
                    <TreeItem nodeId="Ali" label="Ali" />
                </TreeItem>
                <TreeItem nodeId="Team C" label="Team C">
                    <TreeItem nodeId="Gururaj" label="Gururaj" />
                    <TreeItem nodeId="Kamal" label="Kamal" />
                </TreeItem>
            </TreeView>
        );

    }
}