import { useState } from 'react'
import './style.css'

export default function Exercise2() {

	const [animalList, setAnimalList] = useState([
		{ name: "dog", icon: require('../../assets/img/dog.png') },
		{ name: "cat", icon: require('../../assets/img/cat.png') },
		{ name: "chicken", icon: require('../../assets/img/chicken.png') },
		{ name: "cow", icon: require('../../assets/img/cow.png') },
		{ name: "horse", icon: require('../../assets/img/horse.png') },
		{ name: "sheep", icon: require('../../assets/img/sheep.png') },
	])

	return (
		<ul className="animal-list exercise-container">
			{
				animalList.map((animal, index) =>
					<li key={index} className="animal">
						<img src={animal.icon} />
						<p>{animal.name}</p>
					</li>
				)
			}
		</ul>
	)
}