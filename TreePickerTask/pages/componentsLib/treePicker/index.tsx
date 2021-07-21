import React from 'react';
import InitializeComponents from '../../../components/TreePicker/index';

export default function TreePickerModulus() {
    let teamAmembers = ['Pesho', 'Kolyo', 'Stavri'];
    let teamBmembers = ['Pankaj', 'Ali'];
    let teamCmembers = ['Gururaj', 'Kamal'];

    let treePickerInput = {
        TeamA: teamAmembers,
        TeamB: teamBmembers,
        TeamC: teamCmembers
    }

    const [buttonState, setButtonState] = React.useState(false);

    return (
        <div>
            <button className='ButtonForDropdown' onClick={() => setButtonState(!buttonState)}>Teams</button>
            <div style={{ display: (buttonState ? 'block' : 'none') }}><InitializeComponents treePickerInput={treePickerInput}/></div>
        </div>
    )
}