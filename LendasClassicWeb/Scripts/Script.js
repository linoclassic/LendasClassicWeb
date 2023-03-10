$(document).ready(function () {
    $("#txtTelefone").mask("(00) 0000-0000");
});

$(document).ready(function () {
    $("#txtCpf").mask("000.000.000-00");
});

function ValidatePasswordLength(source, arguments) {
    if (arguments.Value.length !== 8) {
        arguments.IsValid = false;
    } else {
        arguments.IsValid = true;
    }
}