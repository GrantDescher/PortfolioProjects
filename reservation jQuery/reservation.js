"use strict";

$(document).ready( () => {
	const emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;
	const TFIR = "This field is required."
	const MBN = "Must be numeric."
	const MBVE = "Must be valid email."
	
	// Move focus to arrival date textbox
	$("#arrival_date").focus();

	// Perform form validation when submit button is clicked
	$("#reservation_form").submit (evt => {
		let isValid = true;

		// Validate arrival date
		const arrivalDate = $("#arrival_date").val().trim()
		if (arrivalDate === "")
		{
			$("#arrival_date").next().text(TFIR);
			isValid = false;
		}
		else
		{
			$("#arrival_date").next().text("");
		}
		$("#arrival_date").val(arrivalDate)

		// Validate number of nights
		const nights = $("#nights").val().trim()
		if (nights === "")
		{
			$("#nights").next().text(TFIR)
			isValid = false;
		}
		else if (isNaN(nights))
		{
			$("#nights").next().text(MBN)
			isValid = false;
		}
		else
		{
			$("#nights").next().text("");
		}
		$("#nights").val(nights)

		// Validate name
		const name = $("#name").val().trim();
		if (name === "")
		{
			$("#name").next().text(TFIR)
			isValid = false;
		}
		else
		{
			$("#name").next().text("");
		}
		$("#name").val(name)

		// Validate email
		const email = $("#email").val().trim();
		if (email === "")
		{
			$("#email").next().text(TFIR);
			isValid = false;
		}
		else if (!emailPattern.test(email))
		{
			$("#email").next().text(MBVE);
			isValid = false;
		}
		else
		{
			$("#email").next().text("");
		}
		$("#email").val() = email;

		// Validate phone
		const phone = $("#phone").val().trim();
		if (phone === "")
		{
			$("#phone").next().text(TFIR);
			isValid = false;
		}
		else
		{
			$("#phone").next().text("");
		}
		$("#phone").val() = email;

		if (!isValid)
		{
			evt.preventDefault();
		}

	})
}); // end ready