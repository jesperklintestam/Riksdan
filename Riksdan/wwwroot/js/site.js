function toggleParty(button, party) {
    console.log(party);
    var partyDiv = document.getElementById(party);
    if (partyDiv.style.display === "none")
    {
        partyDiv.style.display = "block";
        button.classList.remove("inactive");
    }
    else
    {
        partyDiv.style.display = "none";
        button.classList.add("inactive");
    }
}