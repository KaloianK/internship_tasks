import React from 'react';
import PropTypes from 'prop-types';
import Food from './Food';


class SnakeBoard extends React.Component {
    constructor(props) {
        super(props);

        this.food = Food;
        this.pieceCounter = 4;
        this.score = 0;
        this.squareSize = this.props.snakeSize;
        this.horizontalAdjustment = this.props.snakeSize;
        this.verticalAdjustment = 0;
        this.startX = 200;
        this.startY = 200;
        this.startDirection = 39;
        this.keyLeft = 37;
        this.keyUp = 38;
        this.keyRight = 39;
        this.keyDown = 40;
        this.boardColor = 'white';
        this.borderColor = 'green';
        this.snakeColor = 'red';
        this.foodColor = 'lightgreen';
        this.borderKillColor = 'darkred';

        this.boardRef = React.createRef();
        this.main = this.main.bind(this);
        this.drawCanvas = this.drawCanvas.bind(this);
        this.moveSnake = this.moveSnake.bind(this);
        this.drawSnake = this.drawSnake.bind(this);
        this.drawSnakePart = this.drawSnakePart.bind(this);
        this.getSnakeBoardStyles = this.getSnakeBoardStyles.bind(this);
        this.changeDirection = this.changeDirection.bind(this);
        this.drawFood = this.drawFood.bind(this);
        this.refreshFoodPosition = this.refreshFoodPosition.bind(this);
        this.setFoodPosition = this.setFoodPosition.bind(this);
        this.growIfFoodEaten = this.growIfFoodEaten.bind(this);
        this.checkForCollision = this.checkForCollision.bind(this);
        this.resetGame = this.resetGame.bind(this);
        this.initializeSnakePart = this.initializeSnakePart.bind(this);
        this.initializeSnake = this.initializeSnake.bind(this);
        this.setUpdatedSnakeCoordinates = this.setUpdatedSnakeCoordinates.bind(this);
        this.refreshSnake = this.refreshSnake.bind(this);
        this.checkForHeadCollision = this.checkForHeadCollision.bind(this);
        this.getSnakeBoardByID = this.getSnakeBoardByID.bind(this);

        this.state = {
            lastKeyPressed: this.startDirection,
            snake: this.initializeSnake()
        }
    }

    initializeSnakePart(position) {
        return { x: this.startX - (position * this.horizontalAdjustment), y: this.startY - (position * this.verticalAdjustment) };
    }

    initializeSnake() {
        let result = [];

        for (let i = 0; i < this.pieceCounter; i++) {
            result.push(this.initializeSnakePart(i))
        }

        return result;
    }

    componentDidMount() {
        this.setFoodPosition(this.getRandomPosition(this.boardRef));
        this.main(this.boardRef, this.gameRef);
    }

    componentDidUpdate(prevProps) {
        if (prevProps.snakeSize !== this.props.snakeSize) {
            this.squareSize = this.props.snakeSize;

            this.refreshFoodPosition();
            this.refreshSnake();
        }
    }

    main(board) {
        const _this = this;

        if (this.checkForCollision(board)) {
            let username = prompt(`GameOver! :(\nYour score is ${_this.score} (1 apple = 10 points)\nEnter your username below`, '');

            if (username === null) {
                _this.resetGame(board);
            } else if (username === '') {
                _this.props.saveUserScore(username, _this.score);
                _this.resetGame(board);
            } else {
                while (username.length < 3 && username !== '') {
                    username = prompt(`GameOver! :(\nYour score is ${_this.score} (1 apple = 10 points)\nEnter your username below`, '')
                    
                    if (username === null) {
                        _this.resetGame(board);
                        break;
                    }
                }

                _this.props.saveUserScore(username, _this.score);
                _this.resetGame(board);
            }
        }

        document.addEventListener('keydown', _this.changeDirection);

        setTimeout(function onTick() {
            _this.drawCanvas(board);
            _this.moveSnake(board);
            _this.drawSnake();
            _this.drawFood();
            _this.growIfFoodEaten();
            _this.main(board);
        }, _this.props.snakeSpeed)
    }

    setLastKeyPressed(keyCode) {
        this.setState({
            lastKeyPressed: keyCode
        });
    }

    getRandomPosition(board) {
        const x = Math.round(Math.random() * (board.current.width - (this.squareSize / 2)));
        const y = Math.round(Math.random() * (board.current.width - (this.squareSize / 2)));

        return {
            x: x - x % this.squareSize + (this.squareSize / 2),
            y: y - y % this.squareSize + (this.squareSize / 2)
        };
    }

    resetGame() {
        this.pieceCounter = 4;
        this.setState({
            lastKeyPressed: 39,
            snake: this.initializeSnake()
        });

        

        this.drawSnake();
        this.score = 0;
    }
    
    //CanvasStuff
    getSnakeBoardStyles() {
        return this.boardRef.current.getContext("2d");
    }

    getSnakeBoardByID() {
        return document.getElementById('snakeCanvas');
    }

    drawCanvas(board) {
        const snakeBoardStyles = this.getSnakeBoardStyles();
        const snakeBoardByID = this.getSnakeBoardByID();

        const snakeBoard = board.current;

        if (this.props.discoSnake) {
            let randomColor = Math.floor(Math.random() * 16777215).toString(16);

            snakeBoardStyles.fillStyle = `#${randomColor}`;
        } else {
            snakeBoardStyles.fillStyle = this.boardColor;
        }

        if (this.props.allowBorders) {
            snakeBoardByID.style.borderColor = this.borderKillColor;
        } else {
            snakeBoardByID.style.borderColor = this.borderColor;
        }

        snakeBoardStyles.fillRect(0, 0, snakeBoard.width, snakeBoard.height);
    }

    //Snake Stuff
    drawSnake() {
        this.state.snake.forEach(this.drawSnakePart);
    }

    drawSnakePart(snakePart) {
        const snakeBoardStyles = this.getSnakeBoardStyles();

        if (this.props.discoSnake) {
            let randomColor = Math.floor(Math.random() * 16777215).toString(16);

            snakeBoardStyles.fillStyle = `#${randomColor}`;
        } else {
            snakeBoardStyles.fillStyle = this.snakeColor;
        }

        snakeBoardStyles.strokeStyle = this.borderColor;
        snakeBoardStyles.fillRect(snakePart.x, snakePart.y, this.props.snakeSize, this.props.snakeSize);
        snakeBoardStyles.strokeRect(snakePart.x, snakePart.y, this.props.snakeSize, this.props.snakeSize);
    }

    moveSnake(board) {
        let newSnakePos = [...this.state.snake];
        let snakeHead = { x: newSnakePos[0].x + this.horizontalAdjustment, y: newSnakePos[0].y + this.verticalAdjustment };
        const snakeBoard = board.current;

        if (this.props.allowBorders) {
            newSnakePos.unshift(snakeHead);
            newSnakePos.pop();

            this.setState({ snake: newSnakePos });
        } else {

            if (snakeHead.x < 0) {
                snakeHead.x = snakeBoard.width - this.squareSize;
            }

            if (snakeHead.x === snakeBoard.width || snakeHead.x === (snakeBoard.width - this.squareSize / 2)) {
                snakeHead.x = 0;
            }

            if (snakeHead.y < 0) {
                snakeHead.y = snakeBoard.height - this.squareSize;
            }

            if (snakeHead.y === snakeBoard.height || snakeHead.y === (snakeBoard.height - this.squareSize / 2)) {
                snakeHead.y = 0;
            }

            newSnakePos.unshift(snakeHead);
            newSnakePos.pop();

            this.setState({
                snake: newSnakePos
            });
        }
    }

    changeDirection(event) {
        const keyPressed = event.keyCode;
        const { lastKeyPressed } = this.state;

        if (keyPressed === this.keyLeft && lastKeyPressed !== this.keyRight) {
            this.horizontalAdjustment = -this.squareSize;
            this.verticalAdjustment = 0;

            this.setLastKeyPressed(keyPressed);
        }

        if (keyPressed === this.keyUp && lastKeyPressed !== this.keyDown) {
            this.horizontalAdjustment = 0;
            this.verticalAdjustment = -this.squareSize;

            this.setLastKeyPressed(keyPressed);
        }

        if (keyPressed === this.keyRight && lastKeyPressed !== this.keyLeft) {
            this.horizontalAdjustment = this.squareSize;
            this.verticalAdjustment = 0;

            this.setLastKeyPressed(keyPressed);
        }

        if (keyPressed === this.keyDown && lastKeyPressed !== this.keyUp) {
            this.horizontalAdjustment = 0;
            this.verticalAdjustment = this.squareSize;

            this.setLastKeyPressed(keyPressed);
        }
    }

    growIfFoodEaten() {
        const head = { x: this.state.snake[0].x + (this.props.snakeSize / 2), y: this.state.snake[0].y + (this.props.snakeSize / 2) };

        if (head.x === this.state.food.x && head.y === this.state.food.y) {
            this.setFoodPosition(this.getRandomPosition(this.boardRef));
            this.setState({ snake: this.growSnake(head, this.state.snake) });

            this.pieceCounter++;
            this.score += 10;
        }
    }

    growSnake(head, snake) {
        const newSnake = [...snake];

        newSnake.push([{ x: head - this.pieceCounter * this.horizontalAdjustment, y: head - this.pieceCounter * this.verticalAdjustment }]);

        return newSnake;
    }

    checkForHeadCollision(currentPartX, currentPartY) {
        const head = { x: this.state.snake[0].x, y: this.state.snake[0].y };

        return head.x === currentPartX && head.y === currentPartY;
    }

    checkForCollision(board) {
        let newSnakePos = [...this.state.snake];
        const ateItself = newSnakePos.some((currentPart, index) => index !== 0 && this.checkForHeadCollision(currentPart.x, currentPart.y));

        if (this.props.allowBorders) {
            const snakeBoard = board.current;
            const leftWallCollision = newSnakePos[0].x < 0;
            const rightWallCollision = newSnakePos[0].x > snakeBoard.width - this.props.snakeSize;
            const topWallCollision = newSnakePos[0].y < 0;
            const bottomWallCollision = newSnakePos[0].y > snakeBoard.height - this.props.snakeSize;

            return leftWallCollision || rightWallCollision || topWallCollision || bottomWallCollision;
        }

        return ateItself;
    }

    setUpdatedSnakeCoordinates(snakePart, snakeSizeChange) {
        let { x, y } = snakePart;
        let newSnakeX = 0;
        let newSnakeY = 0;

        if (this.state.lastKeyPressed === this.keyLeft) {
            newSnakeX = (x - snakeSizeChange) - (x - snakeSizeChange) % this.props.snakeSize;
            newSnakeY = y;

            this.horizontalAdjustment = -this.squareSize;
            this.verticalAdjustment = 0;
        }

        if (this.state.lastKeyPressed === this.keyUp) {
            newSnakeX = x;
            newSnakeY = y - snakeSizeChange - (y - snakeSizeChange) % this.props.snakeSize;

            this.horizontalAdjustment = 0;
            this.verticalAdjustment = -this.squareSize;
        }

        if (this.state.lastKeyPressed === this.keyRight) {
            newSnakeX = x + snakeSizeChange - (x - snakeSizeChange) % this.props.snakeSize;
            newSnakeY = y;

            this.horizontalAdjustment = this.squareSize;
            this.verticalAdjustment = 0;
        }

        if (this.state.lastKeyPressed === this.keyDown) {
            newSnakeX = x;
            newSnakeY = y + snakeSizeChange - (y - snakeSizeChange) % this.props.snakeSize;

            this.horizontalAdjustment = 0;
            this.verticalAdjustment = this.squareSize;
        }

        return { x: newSnakeX, y: newSnakeY };
    }

    refreshSnake() {
        let snakeCopy = this.state.snake;

        return snakeCopy.map(this.setUpdatedSnakeCoordinates);
    }

    //Food Stuff
    drawFood() {
        const snakeBoardStyles = this.getSnakeBoardStyles();
        const radius = this.props.snakeSize / 2 - 1;
        let { x: foodX, y: foodY } = this.state.food;

        snakeBoardStyles.beginPath();
        snakeBoardStyles.arc(foodX, foodY, radius, 0, 2 * Math.PI, false);
        snakeBoardStyles.fillStyle = this.foodColor;
        snakeBoardStyles.fill();
        snakeBoardStyles.strokeStyle = this.borderColor;
        snakeBoardStyles.stroke();
    }

    refreshFoodPosition() {
        const { x, y } = this.state.food;

        const newX = x - x % this.squareSize + (this.squareSize / 2);
        const newY = y - y % this.squareSize + (this.squareSize / 2);

        this.setFoodPosition({ x: newX, y: newY });
    }

    setFoodPosition(foodPos) {
        this.setState({ food: foodPos });
    }

   

   

   

    render() {
        return (
            <div>
                <canvas id="snakeCanvas" className='poletoBrat' ref={this.boardRef} width='800' height='800'></canvas>
            </div>
        )
    }
}

SnakeBoard.propTypes = {
    snakeSpeed: PropTypes.number,
    snakeSize: PropTypes.number,
    allowBorders: PropTypes.bool,
    discoSnake: PropTypes.bool,
    userScoresMap: PropTypes.array
};

export default SnakeBoard;