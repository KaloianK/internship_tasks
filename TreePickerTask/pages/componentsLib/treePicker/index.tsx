import React from 'react';
import TreePicker from '../../../components/TreePicker';

export default function TreePickerModulus() {
    let teamAmembers = ['Pesho', 'Kolyo', 'Stavri'];
    let teamBmembers = ['Pankaj', 'Ali'];
    let teamCmembers = ['Gururaj', 'Kamal'];
    let guidCounter = 0;

    let treePickerInput = {
        TeamA: teamAmembers.map((currentMember) => {
            guidCounter++;

            return { guid: guidCounter, name: currentMember }
        }),
        TeamB: teamBmembers.map((currentMember) => {
            guidCounter++;

            return { guid: guidCounter, name: currentMember }
        }),
        TeamC: teamCmembers.map((currentMember) => {
            guidCounter++;

            return { guid: guidCounter, name: currentMember }
        })
    }

    const [buttonState, setButtonState] = React.useState(false);

    return (
        <div>
            <button className='ButtonForDropdown' onClick={() => setButtonState(!buttonState)}>Teams</button>
            {buttonState ? <TreePicker treePickerInput = {treePickerInput}/> : null}
        </div>
    )
}