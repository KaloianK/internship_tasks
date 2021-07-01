import React from 'react';

class SnakeBoard extends React.Component {
    constructor(props) {
        super(props);

        this.pieceCounter = 4;
        this.score = 0;
        this.size = this.props.snakeSize;
        this.dx = this.size;
        this.dy = 0;
        this.startX = 200;
        this.startY = 200;
        this.initialSnakeLength = 4;
        this.startDirection = 39;

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
        this.enlargeIfFoodEaten = this.enlargeIfFoodEaten.bind(this);
        this.checkForCollision = this.checkForCollision.bind(this);
        this.resetGame = this.resetGame.bind(this);
        this.moveSnakeWithBorders = this.moveSnakeWithBorders.bind(this);
        this.checkForCollisionWithBorders = this.checkForCollisionWithBorders.bind(this);
        this.initializeBox = this.initializeBox.bind(this);
        this.initializeSnake = this.initializeSnake.bind(this);

        this.state = {
            lastKeyPressed: this.startDirection,
            snake: this.initializeSnake()
        }
    }

    initializeBox(position) {
        return { x: this.startX - (position * this.dx), y: this.startY - (position * this.dy) }
    }

    initializeSnake() {
        let result = [];

        for (let i = 0; i < this.initialSnakeLength; i++){
            result.push( this.initializeBox(i))
        }

        return result;
    }

    componentDidMount() {
        this.setFoodPosition(this.getRandomPosition(this.boardRef));
        this.main(this.boardRef, this.gameRef);
    }

    componentDidUpdate(prevProps) {
        prevProps.snakeSize !== this.props.snakeSize && this.refreshFoodPosition();
    }

    refreshFoodPosition() {
        const { x, y } = this.state.food;

        const newX = x - x % this.size + (this.props.snakeSize / 2);
        const newY = y - y % this.size + (this.props.snakeSize / 2);

        this.setFoodPosition({ x: newX, y: newY });
    }

    getSnakeBoardStyles() {
        return this.boardRef.current.getContext("2d");
    }

    main(board) {
        const _this = this;

        if (this.props.allowBorders) {
            if (this.checkForCollisionWithBorders(board)) {
                let username = prompt(`GameOver! :(\nYour score is ${this.score} (1 apple = 10 points)\nEnter your username below`, '');

                if (username === null) {
                    _this.resetGame(board);
                }
                else {
                    while (username.length < 3) {
                        username = prompt(`GameOver! :(\nYour score is ${this.score} (1 apple = 10 points)\nEnter your username below`, '')
                    }

                    _this.props.saveUserScore(username, this.score);
                    _this.resetGame(board);
                }
            }

            document.addEventListener('keydown', _this.changeDirection);

            setTimeout(function onTick() {
                _this.drawCanvas(board);
                _this.moveSnakeWithBorders();
                _this.drawSnake();
                _this.drawFood();
                _this.enlargeIfFoodEaten();
                _this.main(board);
            }, this.props.snakeSpeed)
        }
        else {

            if (this.checkForCollision(board)) {
                let username = prompt(`GameOver! :(\nYour score is ${this.score} (1 apple = 10 points)\nEnter your username below`, '');

                while (username.length < 3) {
                    username = prompt(`GameOver! :(\nYour score is ${this.score} (1 apple = 10 points)\nEnter your username below`, '')
                }

                this.props.saveUserScore(username, this.score);
                _this.resetGame(board);
            }

            document.addEventListener('keydown', _this.changeDirection);

            setTimeout(function onTick() {
                _this.drawCanvas(board);
                _this.moveSnake(board);
                _this.drawSnake();
                _this.drawFood();
                _this.enlargeIfFoodEaten();
                _this.main(board);
            }, this.props.snakeSpeed)
    }
}

drawCanvas(board) {
    const snakeBoardStyles = this.getSnakeBoardStyles();
    const snakeBoard = board.current;

    snakeBoardStyles.fillStyle = "white";
    snakeBoardStyles.strokeStyle = "black";
    snakeBoardStyles.strokeStyle = "black";
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
    snakeBoardStyles.fillRect(snakePart.x, snakePart.y, this.props.snakeSize, this.props.snakeSize);
    snakeBoardStyles.strokeRect(snakePart.x, snakePart.y, this.props.snakeSize, this.props.snakeSize);
}

moveSnake(board) {
    let newSnakePos = [...this.state.snake];
    let snakeHead = { x: newSnakePos[0].x + this.dx, y: newSnakePos[0].y + this.dy };
    const snakeBoard = board.current;

    if (snakeHead.x < 0) {
        snakeHead.x = snakeBoard.width - this.props.snakeSize;
    }

    if (snakeHead.x === snakeBoard.width) {
        snakeHead.x = 0;
    }

    if (snakeHead.y < 0) {
        snakeHead.y = snakeBoard.height - this.props.snakeSize;
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

moveSnakeWithBorders() {
    let newSnakePos = [...this.state.snake];
    const head = { x: this.state.snake[0].x + this.dx, y: this.state.snake[0].y + this.dy };

    newSnakePos.unshift(head);
    newSnakePos.pop();

    this.setState({ snake: newSnakePos });
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
        this.dx = -this.props.snakeSize;
        this.dy = 0;

        this.setLastKeyPressed(keyPressed);
    }

    if (keyPressed === keyUp && lastKeyPressed !== keyDown) {
        this.dx = 0;
        this.dy = -this.props.snakeSize;

        this.setLastKeyPressed(keyPressed);
    }

    if (keyPressed === keyRight && lastKeyPressed !== keyLeft) {
        this.dx = this.props.snakeSize;
        this.dy = 0;

        this.setLastKeyPressed(keyPressed);
    }

    if (keyPressed === keyDown && lastKeyPressed !== keyUp) {
        this.dx = 0;
        this.dy = this.props.snakeSize;

        this.setLastKeyPressed(keyPressed);
    }
}

getRandomPosition(board) {
    const x = Math.round(Math.random() * board.current.width);
    const y = Math.round(Math.random() * board.current.height);
    
    // if(this.size === 40) {
    //     return {
    //         x: x - x % this.size ,
    //         y: y - y % this.size
    //     };
    // }

    return {
        x: x - x % this.size + (this.size / 2),
        y: y - y % this.size + (this.size / 2)
    };
}

setFoodPosition(foodPos) {
    this.setState({ food: foodPos });
}

drawFood() {
    const snakeBoardStyles = this.getSnakeBoardStyles();
    const radius = this.props.snakeSize / 2;
    let { x: foodX, y: foodY } = this.state.food;

    snakeBoardStyles.beginPath();
    snakeBoardStyles.arc(foodX, foodY, radius, 0, 2 * Math.PI, false);
    snakeBoardStyles.fillStyle = 'lightgreen';
    snakeBoardStyles.fill();
    snakeBoardStyles.strokeStyle = 'green';
    snakeBoardStyles.stroke();
}

enlargeIfFoodEaten() {
    const head = { x: this.state.snake[0].x + (this.props.snakeSize / 2), y: this.state.snake[0].y + (this.props.snakeSize / 2) };

    if (head.x === this.state.food.x && head.y === this.state.food.y) {
        this.setFoodPosition(this.getRandomPosition(this.boardRef));
        this.setState({ snake: this.enLarge(head, this.state.snake) });

        this.pieceCounter++;
        this.score += 10;
    }
}

enLarge(head, snake) {
    const newSnake = [...snake];

    newSnake.push([{ x: head - this.pieceCounter * this.dx, y: head - this.pieceCounter * this.dy }]);

    return newSnake
}

checkForCollision() {
    const head = { x: this.state.snake[0].x, y: this.state.snake[0].y };

    for (let i = 1; i < this.state.snake.length; i++) {
        if (head.x === this.state.snake[i].x && head.y === this.state.snake[i].y) return true;
    }
}

checkForCollisionWithBorders(board) {
    let newSnakePos = [...this.state.snake];
    const head = { x: this.state.snake[0].x, y: this.state.snake[0].y };
    const snakeBoard = board.current;
    const leftWallCollision = newSnakePos[0].x < 0;
    const rightWallCollision = newSnakePos[0].x > snakeBoard.width - this.props.snakeSize;
    const topWallCollision = newSnakePos[0].y < 0;
    const bottomWallCollision = newSnakePos[0].y > snakeBoard.height - this.props.snakeSize;

    for (let i = 1; i < this.state.snake.length; i++) {
        if (head.x === this.state.snake[i].x && head.y === this.state.snake[i].y) return true;
    }

    return leftWallCollision || rightWallCollision || topWallCollision || bottomWallCollision;
}

resetGame(board) {
    this.setState({
        lastKeyPressed: 39,
        snake: this.initializeSnake()});
    this.drawSnake();
    this.score = 0;
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