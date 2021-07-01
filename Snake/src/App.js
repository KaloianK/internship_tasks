import React, { useState } from 'react';
import './App.css';
import SnakeBoard from './snakeBoard';
import SomeSnakeStuff from './SomeSnakeStuff';
import { Grid, Button, ButtonGroup, FormControlLabel, Switch, Checkbox } from '@material-ui/core';

function App() {
  const [snakeSpeed, setSnakeSpeed] = useState(60);
  const [snakeSize, setSnakeSize] = useState(20);
  const [userScoresMap, setUserScoreMap] = useState([{ username: 'NaKokoPitonya', score: 'Infinite' }]);
  const [allowBorders, setBorderAllowance] = useState({ allowedBorders: false });

  const saveUserScore = (username, score) => setUserScoreMap([...userScoresMap, { username, score }]);

  const allowedBorders = (event) => {
    setBorderAllowance({ ...allowBorders, [event.target.name]: event.target.checked });
  };

  return (
    <div className="App">
      <div>
        <Grid container>
          <Grid item xs={2}>
            Snake Speed
            <ButtonGroup size="large" color="primary" aria-label="large outlined primary button group">
              <Button id='slowButton' onClick={() => setSnakeSpeed(250)}>Slow</Button>
              <Button id='mediumButton' onClick={() => setSnakeSpeed(60)}>Medium</Button>
              <Button id='fastbutton' onClick={() => setSnakeSpeed(30)}>Fast</Button>
            </ButtonGroup>
            Snake Size
            <ButtonGroup size="large" color="primary" aria-label="large outlined primary button group">
              <Button id='smallSnakeButton' onClick={() => setSnakeSize(10)}>10x10</Button>
              <Button id='mediumSnakeButton' onClick={() => setSnakeSize(20)}>20x20</Button>
              <Button id='mediumSnakeButton' onClick={() => setSnakeSize(30)}>30x30</Button>
              <Button id='largeSnakeButton' onClick={() => setSnakeSize(40)}>40x40</Button>
            </ButtonGroup>
            <FormControlLabel control={<Switch checked={allowBorders.allowedBorders} onChange={allowedBorders} name='allowedBorders' />} label="Borders Kill" />
          </Grid>
          <Grid item xs={8}><SnakeBoard snakeSpeed={snakeSpeed} snakeSize={snakeSize} saveUserScore={saveUserScore} allowBorders={allowBorders.allowedBorders} /></Grid>

          <Grid id='highscore'>
            Highest Scores:
            <SomeSnakeStuff userScoresMap={userScoresMap} />
          </Grid>
        </Grid>
      </div>
    </div>
  );
}

export default App;
