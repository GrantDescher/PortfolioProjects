const $ = selector => document.querySelector(selector)

document.addEventListener("DOMContentLoaded",() => {
	const processEntries = () => {
		const firstName = $("#firstName")
		const lastName  = $("#lastName")
		const address   = $("#address")
		const city      = $("#city")
		const state     = $("#state")
		const zip       = $("#zip")
		const email     = $("#email")
	    const phone     = $("#phone")

		const msgs = []

		let timer = null

		if (firstName.value == "")
		{
			msgs[msgs.length] = "Please enter a first name."
		}

		if (lastName.value == "")
		{
			msgs[msgs.length] = "Please enter a last name."
		}

		if (address.value == "")
		{
			msgs[msgs.length] = "Please enter an address."
		}

		if (city.value == "")
		{
			msgs[msgs.length] = "Please enter a city."
		}

		if (state.value == "")
		{
			msgs[msgs.length] = "Please enter a state."
		}

		if (zip.value == "")
		{
			msgs[msgs.length] = "Please enter a zip code."
		}

		if (email.value == "")
		{
			msgs[msgs.length] = "Please enter an email address."
		}

		if (phone.value == "")
		{
			msgs[msgs.length] = "Please enter a phone number."
		}

		if (msgs.length == 0)
		{
			displayPicture()
		}
		else 
		{
			displayErrorMessages(msgs)
		}
	}

	const displayPicture = () => {
		elem = document.createElement("img")
		elem.setAttribute("src", "images/thankYou.png")
		document.getElementById("thankYouPicture").appendChild(elem)
	}

	const displayErrorMessages = msgs => {
		const ul = document.createElement("ul")
		ul.classList.add("messages")

		for (let msg of msgs)
		{
			const li = document.createElement("li")
			const text = document.createTextNode(msg)
			li.appendChild(text)
			ul.appendChild(li)
		}

		const node = $("ul")
		if (node == null)
		{
			const form = $("form")
			form.parentNode.insertBefore(ul, form)
		}
		else
		{
			node.parentNode.replaceChild(ul, node)
		}
	}

	const clearFields = () => {
		$("#firstName").value = ""
		$("#lastName").value = ""
		$("#address").value = ""
		$("#city").value = ""
		$("#state").value = ""
		$("#zip").value = ""
		$("#email").value = ""
		$("#phone").value = ""
		$("#firstName").focus()
		$("#thankYouPicture").textContent = ""
		$("#messages").textContent = ""
	}

	$("#sub").addEventListener("click", evt => {
			processEntries()
	})

	$("#clear").addEventListener("click", evt => {
		timer = setTimeout(clearFields, 5000)
	})
})