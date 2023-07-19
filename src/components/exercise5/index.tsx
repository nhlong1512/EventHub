import { TextField, Button, Zoom, Alert } from "@mui/material"
import { useState } from "react"
import "./style.css"

export default function Exercise5() {
	const [firstName, setFirstName] = useState("")

	const [lastName, setLastName] = useState("")

	const [result, setResult] = useState("")

	const [isButtonDisabled, setIsButtonDisabled] = useState(true)

	const [firstNameError, setFirstNameError] = useState(false)

	const [lastNameError, setLastNameError] = useState(false)

	const handleFormOnSubmit = () => {
		if (isValidInputs())
			setResult(firstName + " " + lastName)
		else {
			setResult("")
		}
	}

	const handleOnKeyDown = (e: React.KeyboardEvent<HTMLDivElement>) => {
		if (e.key === "Enter" && !isButtonDisabled) handleFormOnSubmit()
	}

	const isValidInputs = () => {
		if (/[^a-zA-Z]/i.test(firstName) || firstName.includes("  ")){
			setFirstNameError(true)
			return false
		}
		if (/[^a-zA-Z]/i.test(lastName) || lastName.includes("  ")){
			setLastNameError(true)
			return false
		}
		return true
	}

	const handleInputOnchange = (
		value: string,
		setValue: React.Dispatch<React.SetStateAction<string>>
	) => {
		setValue(value)
		setIsButtonDisabled(firstName === "" || lastName === "")
		if(result) setResult("")
		if(firstNameError) setFirstNameError(false)
		if(lastNameError) setLastNameError(false)
	}

	return (
		<div className="exercise-container form-container">
			<form>
				<TextField
					id="outlined-basic"
					label="First name"
					variant="outlined"
					value={firstName}
					onChange={(e) => handleInputOnchange(e.target.value, setFirstName)}
					onKeyDown={(e) => handleOnKeyDown(e)}
					margin="dense"
					fullWidth
					error={firstNameError}
				/>

				<TextField
					id="outlined-basic"
					label="Last name"
					variant="outlined"
					value={lastName}
					onChange={(e) => handleInputOnchange(e.target.value, setLastName)}
					onKeyDown={(e) => handleOnKeyDown(e)}
					margin="dense"
					fullWidth
					error={lastNameError}
				/>

				<Button
					variant="contained"
					disabled={isButtonDisabled}
					onClick={handleFormOnSubmit}
				>
					Greet me
				</Button>
			</form>

			<div className="alert-container">
				<Zoom in={firstNameError || lastNameError} className="alert">
					<Alert severity="error">
						- Name cannot be empty. <br/>
						- Name cannot contains numbers, special characters. <br/>
						- Name cannot contains only spaces or consecutive spaces.
					</Alert>
				</Zoom>

				<Zoom in={result !== ""}  className="alert">
					<Alert
						severity="success"
						action={
							<Button color="inherit" size="small" onClick={() => {
								setResult("")
								setFirstName("")
								setLastName("")
								setIsButtonDisabled(true)
							}}>
								Hide
							</Button>
						}
					>
						Full name is <strong>{result}</strong>
					</Alert>
				</Zoom>
			</div>
		</div>
	)
}