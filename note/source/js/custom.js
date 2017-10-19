  $(document).ready(function () {
      // the "href" attribute of the modal trigger must specify the modal ID that wants to be triggered
      $('.modal').modal();
  });

  function reset() {
      document.getElementById("noteTitle").value = ""; // Create text with HTML
      document.getElementById("noteContent").value = "";
  }


  function newNote() {
      var title = document.getElementById("noteTitle").value; // Create text with HTML
      var content = document.getElementById("noteContent").value;
      $(".container").append("<div class='card blue-grey darken-1'><div class='card-content white-text'><span class='card-title'>" + title + "</span><p>" + content + "</p></div><div class='card-action'><a href='#' onclick='dismissNote();'>dismiss</a></div></div>");
      Materialize.toast('Added successfully!', 4000)
  }

  function dismissNote() {
      $('.card-action').on('click', function () {
          $(this).parent('div.card').remove();
          Materialize.toast('Dismiss successfully!', 4000)
      });
  }