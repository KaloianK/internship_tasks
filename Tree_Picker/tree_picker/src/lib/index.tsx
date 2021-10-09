import React, { useState } from 'react';
import { Button } from '@material-ui/core';
import TreePicker from '../components/treePicker';

export function TreePickerComponent(): JSX.Element {
    let team_A = ['Pesho', 'Kolyo', 'Stavri'];
    let team_B = ['Pankaj', 'Ali'];
    let team_C = ['Gururaj', 'Kamal'];
    let guid = 0;

    let input = {
        TeamA: team_A.map((member: string) => {
            guid++;

            return {name: member, guid: guid};
        }),
        TeamB: team_B.map((member: string) => {
            guid++;

            return {name: member, guid: guid};
        }),
        TeamC: team_C.map((member: string) => {
            guid++;

            return {name: member, guid: guid};
        }),
    };

    const [buttonsState, setButtonState] = useState(false);
//To Do: Trigger should be in a file so it can be configurable
    return (
        <div>
            <Button variant='outlined' onClick={() => setButtonState(!buttonsState)}>Teams</Button>
            {buttonsState ? <TreePicker input={input} /> : null}
        </div>
    )
}