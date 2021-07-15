import React, { useState } from 'react';
import './App.css';
import SnakeBoard from './snakeBoard';
import HighScoreTable from './HighScoreTable';
import { Grid, Button, ButtonGroup, FormControlLabel, Switch } from '@material-ui/core';

function App() {
  const [snakeSpeed, setSnakeSpeed] = useState(60);
  const [snakeSize, setSnakeSize] = useState(20);
  const [userScoresMap, setUserScoreMap] = useState([]);
  const [allowBorders, setBorderAllowance] = useState({ allowedBorders: false });
  const [discoSnake, setDiscoSnake] = useState({ allowedDiscoSnake: false });

  const saveUserScore = (username, score) => setUserScoreMap([...userScoresMap, { username, score }]);

  const allowedBorders = (event) => {
    setBorderAllowance({ ...allowBorders, [event.target.name]: event.target.checked });
  };

  const allowedDiscoSnake = (event) => {
    setDiscoSnake({ ...discoSnake, [event.target.name]: event.target.checked });
  };

  return (
    <div className="App">
      <div>
        <Grid container>
          <Grid item xs={2}>
            Snake Speed
            <ButtonGroup size="large" color="primary" aria-label="large outlined primary button group">
              <Button id='slowButton' onClick={() => setSnakeSpeed(250)}>Slow</Button>
              <Button id='mediumButton' variant='contained' onClick={() => setSnakeSpeed(60)}>Medium</Button>
              <Button id='fastbutton' onClick={() => setSnakeSpeed(30)}>Fast</Button>
            </ButtonGroup>
            Snake Size
            <ButtonGroup size="large" color="primary" aria-label="large outlined primary button group">
              <Button id='smallSnakeButton' onClick={() => setSnakeSize(10)}>Small</Button>
              <Button id='mediumSnakeButton' onClick={() => setSnakeSize(20)}>Large</Button>
            </ButtonGroup>
            <FormControlLabel control={<Switch checked={allowBorders.allowedBorders} onChange={allowedBorders} name='allowedBorders' />} label="Borders Kill" />
            <FormControlLabel control={<Switch checked={discoSnake.allowedDiscoSnake} onChange={allowedDiscoSnake} name='allowedDiscoSnake' />} label="Disco snake. Warning!" />
          </Grid>
          <Grid className='snakeBoardGrid' item xs={8}><SnakeBoard snakeSpeed={snakeSpeed} snakeSize={snakeSize} saveUserScore={saveUserScore}
            allowBorders={allowBorders.allowedBorders} discoSnake={discoSnake.allowedDiscoSnake} /></Grid>
          <Grid id='highscore'>
            Highest Scores:
            <HighScoreTable userScoresMap={userScoresMap} />
          </Grid>
        </Grid>
      </div>
    </div>
  );
}

export default App;
