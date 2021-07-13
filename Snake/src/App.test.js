import { render, screen } from '@testing-library/react';
import App from './App';
import SnakeBoard from './snakeBoard';
import assert from 'assert';

test('renders learn react link', () => {
  render(<App />);
  const linkElement = screen.getByText(/learn react/i);
  expect(linkElement).toBeInTheDocument();
});
