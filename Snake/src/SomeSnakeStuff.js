import React, { useState } from 'react';
import './App.css';
import SnakeBoard from './snakeBoard';
import { Grid, Button, ButtonGroup } from '@material-ui/core';
import { makeStyles } from '@material-ui/core/styles';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import Paper from '@material-ui/core/Paper';

const useStyles = makeStyles({
    table: {
        minWidth: 250,
    },
});

// function createData(username, score) {
//     return { username, score };
// }

// const rows = [];

// function getHighScore(username, score) {
//     rows.push(createData(username, score));

//     return rows;
// }

export default function BasicTable(props) {
    const classes = useStyles();
    const rows = props.userScoresMap.sort((userScoreA, userScoreB) => userScoreA.score - userScoreB.score);

    return (
        <TableContainer component={Paper}>
            <Table className={classes.table} aria-label="simple table">
                <TableHead>
                    <TableRow>
                        <TableCell>#</TableCell>
                        <TableCell align="center">Username</TableCell>
                        <TableCell align="center">
                            Score
                        </TableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {rows.map((row, index) => (
                        <TableRow key={row.index}>
                            <TableCell component="th" scope="row">
                                {++index}
                            </TableCell>
                            <TableCell align="right">{row.username}</TableCell>
                            <TableCell align="right">
                                {row.score}
                            </TableCell>
                        </TableRow>
                    ))}
                </TableBody>
            </Table>
        </TableContainer>
    );
}
