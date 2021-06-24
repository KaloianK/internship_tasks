import React, { useState } from 'react';
import './App.css';
import SnakeBoard from './snakeBoard';
import { Grid, Button, ButtonGroup } from '@material-ui/core';

function App() {
  const [snakeSpeed, setSnakeSpeed] = useState(60);


  return (
    <div className="App">
      <div>
        <Grid container>
          <Grid item xs={2}>
            KOP

            <ButtonGroup size="large" color="primary" aria-label="large outlined primary button group">
              <Button id='slowButton' onClick={() => setSnakeSpeed(250)}>Slow</Button>
              <Button id='mediumButton' onClick={() => setSnakeSpeed(60)}>Medium</Button>
              <Button id='fastbutton' onClick={() => setSnakeSpeed(30)}>Fast</Button>
            </ButtonGroup>
          </Grid>
          <Grid item xs={8}><SnakeBoard snakeSpeed={snakeSpeed} /></Grid>
          <Grid item>
            KOPEN
          </Grid>
        </Grid>
      </div>
    </div>
  );
}

function getNextNumber(counter) {
  counter++;

  return counter;
}

export default App;
