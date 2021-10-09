import { Checkbox, Divider } from '@material-ui/core';
import React from 'react';

function TreePicker(props: any): JSX.Element {
    const getComponent = () => {
        const parentArray = Object.keys(props.input);
        const childrenArray: Array<Array<object>> = Object.values(props.input);

        const treePicker = parentArray.map((parentName: string, index: number) => {
            const getParentComponent = () => {
                return (
                    <div>
                        <Checkbox className='parentCheckbox' />
                        {parentName}
                        <Divider/>
                        {getChildren}
                    </div>
                )
            }

            const getChildren = childrenArray[index].map((childInfo: any) => {
                return (
                    <div>
                        <Checkbox className='childCheckbox' />
                        {childInfo.name}
                    </div>
                )
            });

            return (
                <div>
                    {getParentComponent()}
                </div>
            );
        });

        return treePicker;
    }

    const getTreePicker = () => {

        return (
            <div>
                {getComponent()}
            </div>
        )
    };

    return getTreePicker();
}

export default TreePicker;