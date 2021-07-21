import React from 'react';
import { Theme, createStyles, makeStyles } from '@material-ui/core/styles';
import Accordion from '@material-ui/core/Accordion';
import AccordionSummary from '@material-ui/core/AccordionSummary';
import AccordionDetails from '@material-ui/core/AccordionDetails';
import Typography from '@material-ui/core/Typography';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';
import { Checkbox } from '@material-ui/core';
import FormControlLabel from '@material-ui/core/FormControlLabel';

const useStyles = makeStyles((theme: Theme) =>
    createStyles({
        root: {
            width: '100%',
        },
        heading: {
            fontSize: theme.typography.pxToRem(15),
            fontWeight: theme.typography.fontWeightRegular,
        },
    }),
);

export default function SimpleAccordion() {
    const classes = useStyles();

    return (
        <div className={classes.root}>
            <Accordion>
                <AccordionSummary
                    expandIcon={<ExpandMoreIcon />}
                    aria-controls="panel1a-content"
                    id="panel1a-header"
                >
                    <Typography className={classes.heading}>
                    <FormControlLabel
                        control={<Checkbox />}
                        label="Team A"
                    />
                    </Typography>
                </AccordionSummary>
                <AccordionDetails>
                    <FormControlLabel
                        control={<Checkbox />}
                        label="Pesho"
                    />
                    <FormControlLabel
                        control={<Checkbox />}
                        label="Kolyo"
                    />
                    <FormControlLabel
                        control={<Checkbox />}
                        label="Stavri"
                    />
                </AccordionDetails>
            </Accordion>
            <Accordion>
                <AccordionSummary
                    expandIcon={<ExpandMoreIcon />}
                    aria-controls="panel2a-content"
                    id="panel2a-header"
                >
                    <Typography className={classes.heading}>
                    <FormControlLabel
                        control={<Checkbox />}
                        label="Team B"
                    />
                    </Typography>
                </AccordionSummary>
                <AccordionDetails>
                    <FormControlLabel
                        control={<Checkbox />}
                        label="Pankaj"
                    />
                    <FormControlLabel
                        control={<Checkbox />}
                        label="Ali"
                    />
                </AccordionDetails>
            </Accordion>
            <Accordion>
                <AccordionSummary
                    expandIcon={<ExpandMoreIcon />}
                    aria-controls="panel1a-content"
                    id="panel1a-header"
                >
                    <Typography className={classes.heading}>Team A</Typography>
                </AccordionSummary>
                <AccordionDetails>
                    <FormControlLabel
                        control={<Checkbox />}
                        label="Gururaj"
                    />
                    <FormControlLabel
                        control={<Checkbox />}
                        label="Kamal"
                    />
                </AccordionDetails>
            </Accordion>
        </div>
    );
}
