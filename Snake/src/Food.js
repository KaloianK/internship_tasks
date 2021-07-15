import React from 'react';

class Food extends React.Component {
    constructor(...props) {
        super(...props);

        this.foodColor = 'lightgreen';
        this.startX = 200;
        this.startY = 200;

        this.state = {
            food: {x: this.startX, y: this.startY}
        };
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
}
export default Food;