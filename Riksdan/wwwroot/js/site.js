function toggleParty(button, party) {
    var partyDiv = document.getElementById(party);
    var partyPeople = partyDiv.getElementsByClassName("party-people")[0];
    if (partyPeople.style.display === "none") {
        partyPeople.style.display = "flex";
        partyDiv.classList.remove("inactive");
        button.classList.remove("inactive");
    }
    else {
        partyPeople.style.display = "none";
        partyDiv.classList.add("inactive");
        button.classList.add("inactive");
    }
}