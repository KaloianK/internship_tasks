import React from 'react';

class SnakeBoard extends React.Component {
    constructor(props) {
        super(props);

        this.pieceCounter = 4;
        this.score = 0;
        this.squareSize = this.props.snakeSize;
        this.horizontalAdjustment = this.props.snakeSize;
        this.verticalAdjustment = 0;
        this.startX = 200;
        this.startY = 200;
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
        this.initializeSnakePart = this.initializeSnakePart.bind(this);
        this.initializeSnake = this.initializeSnake.bind(this);
        this.setUpdatedSnakeCoordinates = this.setUpdatedSnakeCoordinates.bind(this);
        this.refreshSnake = this.refreshSnake.bind(this);
        this.drawCanvasWithDiscoSnake = this.drawCanvasWithDiscoSnake.bind(this);
        this.drawDiscoSnake = this.drawDiscoSnake.bind(this);

        this.state = {
            lastKeyPressed: this.startDirection,
            snake: this.initializeSnake()
        }
    }

    initializeSnakePart(position) {
        return { x: this.startX - (position * this.horizontalAdjustment), y: this.startY - (position * this.verticalAdjustment) }
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
            const snakeSizeChange = this.props.snakeSize - prevProps.snakeSize;
            this.squareSize = this.props.snakeSize;

            this.refreshFoodPosition();
            //this.setState({snake: this.refreshSnake(snakeSizeChange)});
        } 
    }

    refreshFoodPosition() {
        const { x, y } = this.state.food;

        const newX = x - x % this.squareSize + (this.squareSize / 2);
        const newY = y - y % this.squareSize + (this.squareSize / 2);

        this.setFoodPosition({ x: newX, y: newY });
    }

    setUpdatedSnakeCoordinates(snakePart, snakeSizeChange) {
        let { x, y } = snakePart;
        let newSnakeX = 0;
        let newSnakeY = 0;

        if (this.state.lastKeyPressed === 37) {
            newSnakeX = (x - snakeSizeChange) - (x - snakeSizeChange) % this.props.snakeSize;
            newSnakeY = y;

            this.horizontalAdjustment = -this.squareSize;
            this.verticalAdjustment = 0;
        }

        if (this.state.lastKeyPressed === 38) {
            newSnakeX = x;
            newSnakeY = y - snakeSizeChange - (y - snakeSizeChange) % this.props.snakeSize;

            this.horizontalAdjustment = 0;
            this.verticalAdjustment = -this.squareSize;
        }

        if (this.state.lastKeyPressed === 39) {
            newSnakeX = x + snakeSizeChange - (x - snakeSizeChange) % this.props.snakeSize;
            newSnakeY = y;

            this.horizontalAdjustment = this.squareSize;
            this.verticalAdjustment = 0;
        }

        if (this.state.lastKeyPressed === 40) {
            newSnakeX = x;
            newSnakeY = y + snakeSizeChange - (y - snakeSizeChange) % this.props.snakeSize;

            this.horizontalAdjustment = 0;
            this.verticalAdjustment = this.squareSize;
        }


        return {x: newSnakeX, y: newSnakeY};
    }

    refreshSnake(snakeSizeChange) {
        let newSnake = [];
        let snakeCopy = this.state.snake;
        for (let i = 0; i < snakeCopy.length; i++) {
            newSnake.push(this.setUpdatedSnakeCoordinates(snakeCopy[i], snakeSizeChange));
        }

        return newSnake;
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
                    _this.resetGame();
                }
                else {
                    while (username.length < 3) {
                        username = prompt(`GameOver! :(\nYour score is ${this.score} (1 apple = 10 points)\nEnter your username below`, '')
                    }

                    _this.props.saveUserScore(username, this.score);
                    _this.resetGame();
                }
            }

            document.addEventListener('keydown', _this.changeDirection);

            setTimeout(function onTick() {
                if (_this.props.discoSnake) {
                    _this.drawCanvasWithDiscoSnake(board);
                    _this.moveSnakeWithBorders();
                    _this.drawSnake();
                    _this.drawFood();
                    _this.enlargeIfFoodEaten();
                    _this.main(board);
                }
                else {
                    _this.drawCanvas(board);
                    _this.moveSnakeWithBorders();
                    _this.drawSnake();
                    _this.drawFood();
                    _this.enlargeIfFoodEaten();
                    _this.main(board);
                }
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
                if (_this.props.discoSnake) {
                    _this.drawCanvasWithDiscoSnake(board);
                    _this.moveSnake(board);
                    _this.drawSnake();
                    _this.drawFood();
                    _this.enlargeIfFoodEaten();
                    _this.main(board);
                }
                else {
                    _this.drawCanvas(board);
                    _this.moveSnake(board);
                    _this.drawSnake();
                    _this.drawFood();
                    _this.enlargeIfFoodEaten();
                    _this.main(board);
                }
            }, this.props.snakeSpeed)
        }
    }

    drawCanvas(board) {
        const snakeBoardStyles = this.getSnakeBoardStyles();
        const snakeBoard = board.current;

        snakeBoardStyles.fillStyle = 'white';
        snakeBoardStyles.strokeStyle = "black";
        snakeBoardStyles.fillRect(0, 0, snakeBoard.width, snakeBoard.height);
        snakeBoardStyles.strokeRect(0, 0, snakeBoard.width, snakeBoard.height);

    }

    drawCanvasWithDiscoSnake(board) {
        const snakeBoardStyles = this.getSnakeBoardStyles();
        const snakeBoard = board.current;
        let randomColor = Math.floor(Math.random() * 16777215).toString(16);

        snakeBoardStyles.fillStyle = `#${randomColor}`;
        snakeBoardStyles.strokeStyle = "black";
        snakeBoardStyles.fillRect(0, 0, snakeBoard.width, snakeBoard.height);
        snakeBoardStyles.strokeRect(0, 0, snakeBoard.width, snakeBoard.height);
    }

    drawSnake() {
        if (this.props.discoSnake) {
            this.state.snake.forEach(this.drawDiscoSnake)
        }
        else {
            this.state.snake.forEach(this.drawSnakePart);
        }
    }

    drawDiscoSnake(snakePart) {
        const snakeBoardStyles = this.getSnakeBoardStyles();
        let randomColor = Math.floor(Math.random() * 16777215).toString(16);

        snakeBoardStyles.fillStyle = `#${randomColor}`;
        snakeBoardStyles.strokeStyle = 'black';
        snakeBoardStyles.fillRect(snakePart.x, snakePart.y, this.props.snakeSize, this.props.snakeSize);
        snakeBoardStyles.strokeRect(snakePart.x, snakePart.y, this.props.snakeSize, this.props.snakeSize);
    }

    drawSnakePart(snakePart) {
        const snakeBoardStyles = this.getSnakeBoardStyles();

        snakeBoardStyles.fillStyle = 'red';
        snakeBoardStyles.strokeStyle = 'black';
        snakeBoardStyles.fillRect(snakePart.x, snakePart.y, this.props.snakeSize, this.props.snakeSize);
        snakeBoardStyles.strokeRect(snakePart.x, snakePart.y, this.props.snakeSize, this.props.snakeSize);

    }


    moveSnake(board) {
        let newSnakePos = [...this.state.snake];
        let snakeHead = { x: newSnakePos[0].x + this.horizontalAdjustment, y: newSnakePos[0].y + this.verticalAdjustment };
        const snakeBoard = board.current;

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

    moveSnakeWithBorders() {
        let newSnakePos = [...this.state.snake];
        const head = { x: this.state.snake[0].x + this.horizontalAdjustment, y: this.state.snake[0].y + this.verticalAdjustment };

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
            this.horizontalAdjustment = -this.squareSize;
            this.verticalAdjustment = 0;

            this.setLastKeyPressed(keyPressed);
        }

        if (keyPressed === keyUp && lastKeyPressed !== keyDown) {
            this.horizontalAdjustment = 0;
            this.verticalAdjustment = -this.squareSize;

            this.setLastKeyPressed(keyPressed);
        }

        if (keyPressed === keyRight && lastKeyPressed !== keyLeft) {
            this.horizontalAdjustment = this.squareSize;
            this.verticalAdjustment = 0;

            this.setLastKeyPressed(keyPressed);
        }

        if (keyPressed === keyDown && lastKeyPressed !== keyUp) {
            this.horizontalAdjustment = 0;
            this.verticalAdjustment = this.squareSize;

            this.setLastKeyPressed(keyPressed);
        }
    }

    getRandomPosition(board) {
        const x = Math.round(Math.random() * board.current.width);
        const y = Math.round(Math.random() * board.current.height);

        return {
            x: x - x % this.squareSize + (this.squareSize / 2),
            y: y - y % this.squareSize + (this.squareSize / 2)
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

        newSnake.push([{ x: head - this.pieceCounter * this.horizontalAdjustment, y: head - this.pieceCounter * this.verticalAdjustment }]);

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

    resetGame() {
        this.pieceCounter = 4;
        this.setState({
            lastKeyPressed: 39,
            snake: this.initializeSnake()
        });
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