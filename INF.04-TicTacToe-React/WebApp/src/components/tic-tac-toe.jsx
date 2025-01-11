import '../App.css'
import useTicTacToe from '../hooks/use-tic-tac-toe'

function TicTacToe() {
    const { board, resetGame, getStatusMsg, handleClick } = useTicTacToe()

    return (
        <>
            <div className="game">
                <div className="status">{getStatusMsg()}</div>
                <button className="reset-button" onClick={resetGame}>
                    Reset Game
                </button>
            </div>

            <div className="board">
                {board.map((b, index) => (
                    <button
                        className="cell"
                        key={index}
                        onClick={() => handleClick(index)}
                        disabled={b !== null}
                    >
                        {b}
                    </button>
                ))}
            </div>
        </>
    )
}

export default TicTacToe
