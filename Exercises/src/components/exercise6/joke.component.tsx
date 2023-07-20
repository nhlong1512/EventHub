import "./style.css"

export default function Joke(props: {
	setup: string,
	punchline: string
}) {
	return (
		<div className="joke">
			<div className="setup">{props.setup}</div>
			<div className="punchline">{props.punchline}</div>
		</div>
	)
}