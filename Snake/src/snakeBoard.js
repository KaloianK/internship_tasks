import React from 'react';

let pieceCounter = 4;
const snakeSpeed = 60;
let score = 0;
const size = 20;
let dx = size;
let dy = 0;

class SnakeBoard extends React.Component {
    constructor(props) {
        super(props);

        this.boardRef = React.createRef();
        this.main = this.main.bind(this);
        this.drawCanvas = this.drawCanvas.bind(this);
        this.moveSnake = this.moveSnake.bind(this);
        this.drawSnake = this.drawSnake.bind(this);
        this.drawSnakePart = this.drawSnakePart.bind(this);
        this.getSnakeBoardStyles = this.getSnakeBoardStyles.bind(this);
        this.changeDirection = this.changeDirection.bind(this);
        this.drawFood = this.drawFood.bind(this);
        this.setFoodPosition = this.setFoodPosition.bind(this);
        this.isFoodEaten = this.isFoodEaten.bind(this);
        this.checkForCollision = this.checkForCollision.bind(this);

        this.state = {
            lastKeyPressed: 39,
            snake: [{ x: 200, y: 200 },
            { x: 180, y: 200 },
            { x: 160, y: 200 },
            { x: 140, y: 200 }]
        }
    }

    componentDidMount() {
        this.setFoodPosition(this.boardRef);
        this.main(this.boardRef, this.gameRef);
    }

    getSnakeBoardStyles() {
        return this.boardRef.current.getContext("2d");
    }

    main(board) {
        const _this = this;

        if (this.checkForCollision()) {
            alert(`GameOver! :(\nYour score is ${score} (1 apple = 10 points)`);

            return;  
        } 
        
        document.addEventListener('keydown', _this.changeDirection);
        
        setTimeout(function onTick() {   
            _this.drawCanvas(board);
            _this.moveSnake(board);
            _this.drawSnake();
            _this.drawFood();
            _this.isFoodEaten();
            _this.main(board);
        }, this.props.snakeSpeed)
    }

    drawCanvas(board) {
        const snakeBoardStyles = this.getSnakeBoardStyles();
        const snakeBoard = board.current;

        snakeBoardStyles.fillStyle = "white";
        snakeBoardStyles.strokeStyle = "red";
        snakeBoardStyles.fillRect(0, 0, snakeBoard.width, snakeBoard.height);
        snakeBoardStyles.strokeRect(0, 0, snakeBoard.width, snakeBoard.height);
    }

    drawSnake() {
        this.state.snake.forEach(this.drawSnakePart);
    }

    drawSnakePart(snakePart) {
        const snakeBoardStyles = this.getSnakeBoardStyles();

        snakeBoardStyles.fillStyle = "red";
        snakeBoardStyles.strokeStyle = "black";
        snakeBoardStyles.fillRect(snakePart.x, snakePart.y, size, size);
        snakeBoardStyles.strokeRect(snakePart.x, snakePart.y, size, size);
    }

    moveSnake(board) {
        let newSnakePos = [...this.state.snake];
        let snakeHead = { x: newSnakePos[0].x + dx, y: newSnakePos[0].y + dy };
        const snakeBoard = board.current;

        if (snakeHead.x < 0) {
            snakeHead.x = snakeBoard.width - size;
        }

        if (snakeHead.x === snakeBoard.width) {
            snakeHead.x = 0;
        }

        if (snakeHead.y < 0) {
            snakeHead.y = snakeBoard.height - size;
        }

        if (snakeHead.y === snakeBoard.height) {
            snakeHead.y = 0;
        }

        newSnakePos.unshift(snakeHead);
        newSnakePos.pop();

        this.setState({
            snake: newSnakePos
        });
    }

    setLastKeyPressed(keyCode) {
        this.setState({
            lastKeyPressed: keyCode
        });
    }

    changeDirection(event) {
        const keyLeft = 37;
        const keyUp = 38;
        const keyRight = 39;
        const keyDown = 40;
        const keyPressed = event.keyCode;
        const { lastKeyPressed } = this.state;

        if (keyPressed === keyLeft && lastKeyPressed !== keyRight) {
            dx = -size;
            dy = 0;

            this.setLastKeyPressed(keyPressed);
        }

        if (keyPressed === keyUp && lastKeyPressed !== keyDown) {
            dx = 0;
            dy = -size;

            this.setLastKeyPressed(keyPressed);
        }

        if (keyPressed === keyRight && lastKeyPressed !== keyLeft) {
            dx = size;
            dy = 0;

            this.setLastKeyPressed(keyPressed);
        }

        if (keyPressed === keyDown && lastKeyPressed !== keyUp) {
            dx = 0;
            dy = size;

            this.setLastKeyPressed(keyPressed);
        }
    }

    getRandomPosition(board) {
        const x = Math.floor(Math.random() * board.current.width);
        const y = Math.floor(Math.random() * board.current.height);

        return {
            x: x - x % size + (size / 2),
            y: y - y % size + (size / 2)
        };
    }

    setFoodPosition(board) {
        this.setState({ food: this.getRandomPosition(board) });
    }

    drawFood() {
        const snakeBoardStyles = this.getSnakeBoardStyles();
        const radius = size / 2;
        let { x: foodX, y: foodY } = this.state.food;

        snakeBoardStyles.beginPath();
        snakeBoardStyles.arc(foodX, foodY, radius, 0, 2 * Math.PI, false);
        snakeBoardStyles.fillStyle = 'lightgreen';
        snakeBoardStyles.fill();
        snakeBoardStyles.strokeStyle = 'green';
        snakeBoardStyles.stroke();
    }

    isFoodEaten() {
        const head = { x: this.state.snake[0].x + (size / 2), y: this.state.snake[0].y + (size / 2) };

        if (head.x === this.state.food.x && head.y === this.state.food.y) {
            this.setFoodPosition(this.boardRef);

            this.setState({ snake: this.enLarge(head, this.state.snake) });
            pieceCounter++;
            score += 10;
        }
    }

    enLarge(head, snake) {
        const newSnake = [...snake];

        newSnake.push([{ x: head - pieceCounter * dx, y: head - pieceCounter * dy }]);

        return newSnake
    }

    checkForCollision() {
        const head = { x: this.state.snake[0].x, y: this.state.snake[0].y };
        let hasCollided = false;

        for (let i = 1; i < this.state.snake.length; i++) {
            if (head.x === this.state.snake[i].x && head.y === this.state.snake[i].y) {
                hasCollided = true;
            }
        }

        return hasCollided;
    }

    render() {
        return (
        <div>
            <canvas id="snakeCanvas" className='poletoBrat' ref={this.boardRef} width='800' height='800'></canvas>
        </div>
        )
    }
}

// SnakeBoard.propTypes = {
//     snakeSpeed:
// }

export default SnakeBoard;