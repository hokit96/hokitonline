var title = document.getElementById("noteTitle");
var contents = document.getElementById("noteContent");
var noteTitle = document.getElementById("noteTitle");
var create = document.getElementById("addBtn");

$(document).ready(function () {

    var firebaseRootReference = firebase.database().ref().child("Notes");
    firebaseRootReference.on("child_added", snap => {
        var title = snap.child("Title").val();
        var contents = snap.child("Contents").val();

        $(".container").append(" <div class='card blue-grey darken-1'><div class='card-content white-text'><span class='card-title'>" + title + "</span><p>" + contents + "</p></div><div class='card-action'><a href='#' onclick='dismiss();'>dismiss</a></div></div>");

    });

})





function submit(ref) {
    var title = document.getElementById("noteTitle").value; // Create text with HTML
    var contents = document.getElementById("noteContent").value;
    firebase.database().ref('Notes/').push({
        Title: title,
        Contents: contents
    }).key();

    Materialize.toast('Added successfully!', 1000);
}

function dismiss() {
    let ref = firebase.database().ref('Notes');
    ref.orderByChild('Title').once('value', snapshot => {
        let updates = {};
        snapshot.forEach(child => updates[child.key] = null);
        ref.update(updates);
    });
}








function reset() {
    title.value = ""; // Create text with HTML
    contents.value = "";
}