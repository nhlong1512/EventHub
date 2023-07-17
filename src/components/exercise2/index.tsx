import './style.css'

export default function Exercise2 () {

	let animalList: string[] =  ['dog', 'cat', 'chicken', 'cow', 'sheep', 'horse']

	return (
		<ul className="animal-list">
			{
				animalList.map((animal, index) => 
					<li key={index} className="animal">{animal}</li>	
				)
			}
		</ul>
	)
}