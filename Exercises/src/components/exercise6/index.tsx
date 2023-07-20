import Joke from "./joke.component"
import jokeList from "./data.json"
import "./style.css"

export default function Exercise6() {
	return (
		<div className="exercise-container jokes-container">
			{/* {
				jokeList.map(item => 
					<Joke
						key={item.id} 
						setup={item.setup} 
						punchline={item.punchline}>
					</Joke>
				)
			} */}
		</div>
	)
}