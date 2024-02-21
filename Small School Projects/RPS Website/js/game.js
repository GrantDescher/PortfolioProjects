const $ = selector => document.querySelector(selector)

document.addEventListener("DOMContentLoaded",() => {
	// Declare and initialize program variables
	let randNum = 0
	let totWins = 0
	let totLoss = 0
	let totTies = 0
	let computerGuess = ""

	const calculateForRock = () => {
		randNum = Math.floor(Math.random() * 3) + 1;
		// alert("The randum number is " + randNum)
		elem = document.createElement("img")
		$("#resultPicture").textContent = ""
		let timer = null

		if (randNum === 1)
		{
			computerGuess = "The computer picked rock."
			totTies++

			$("#computerGuess").value = computerGuess
			$("#wins").value = totWins
			$("#losses").value = totLoss
			$("#ties").value = totTies
			elem.setAttribute("src", "images/tiegame.png")
		}

		else if (randNum === 2)
		{
			computerGuess = "The computer picked paper."
			totLoss++

			$("#computerGuess").value = computerGuess
			$("#wins").value = totWins
			$("#losses").value = totLoss
			$("#ties").value = totTies
			elem.setAttribute("src", "images/paper.png")
		}

		else if (randNum === 3)
		{
			computerGuess = "The computer picked scissors."
			totWins++

			$("#computerGuess").value = computerGuess
			$("#wins").value = totWins
			$("#losses").value = totLoss
			$("#ties").value = totTies
			elem.setAttribute("src", "images/rock.png")
		}

		timer = setTimeout(clearFields, 5000)
		document.getElementById("resultPicture").appendChild(elem)
	}

	const calculateForPaper = () => {
		randNum = Math.floor(Math.random() * 3) + 1;
		// alert("The randum number is " + randNum)
		elem = document.createElement("img")
		$("#resultPicture").textContent = ""
		let timer = null

		if (randNum === 1)
		{
			computerGuess = "The computer picked rock."
			totWins++

			$("#computerGuess").value = computerGuess
			$("#wins").value = totWins
			$("#losses").value = totLoss
			$("#ties").value = totTies
			elem.setAttribute("src", "images/paper.png")
		}

		else if (randNum === 2)
		{
			computerGuess = "The computer picked paper."
			totTies++

			$("#computerGuess").value = computerGuess
			$("#wins").value = totWins
			$("#losses").value = totLoss
			$("#ties").value = totTies
			elem.setAttribute("src", "images/tiegame.png")
		}

		else if (randNum === 3)
		{
			computerGuess = "The computer picked scissors."
			totLoss++

			$("#computerGuess").value = computerGuess
			$("#wins").value = totWins
			$("#losses").value = totLoss
			$("#ties").value = totTies
			elem.setAttribute("src", "images/scissors.png")
		}

		timer = setTimeout(clearFields, 5000)
		document.getElementById("resultPicture").appendChild(elem)
	}

	const calculateForScissors = () => {
		randNum = Math.floor(Math.random() * 3) + 1;
		// alert("The randum number is " + randNum)
		elem = document.createElement("img")
		$("#resultPicture").textContent = ""
		let timer = null 

		if (randNum === 1)
		{
			computerGuess = "The computer picked rock."
			totLoss++

			$("#computerGuess").value = computerGuess
			$("#wins").value = totWins
			$("#losses").value = totLoss
			$("#ties").value = totTies
			elem.setAttribute("src", "images/rock.png")
		}

		else if (randNum === 2)
		{
			computerGuess = "The computer picked paper."
			totWins++

			$("#computerGuess").value = computerGuess
			$("#wins").value = totWins
			$("#losses").value = totLoss
			$("#ties").value = totTies
			elem.setAttribute("src", "images/scissors.png")
		}

		else if (randNum === 3)
		{
			computerGuess = "The computer picked scissors."
			totTies++

			$("#computerGuess").value = computerGuess
			$("#wins").value = totWins
			$("#losses").value = totLoss
			$("#ties").value = totTies
			elem.setAttribute("src", "images/tiegame.png")
		}	
		
		timer = setTimeout(clearFields, 5000)
		document.getElementById("resultPicture").appendChild(elem)
	}

	const clearFields = () => {
		$("#computerGuess").value = ""
		$("#resultPicture").textContent = ""
	}

	// If player clicks rock	
	$("#rock").addEventListener("click", evt => {
		calculateForRock()
	})

	// If player clicks paper
	$("#paper").addEventListener("click", evt => {
    calculateForPaper()
	})

	// If player clicks scissors
	$("#scissors").addEventListener("click", evt => {
    calculateForScissors()
	})
})