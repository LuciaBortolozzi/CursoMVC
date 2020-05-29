//$(document).ready(function () {
//    alert("Hola");
//});

function verDisponibilidad(id) {
    var url = "/Libro/VerDisponibilidad?id=" + id;
    $.ajax({
        url: url,
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        complete: function (r) {
            if (r.Data) {
                alert("Disponible");
            } else {
                alert("No disponible");
            }
        }
    });
}

