// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function formataValorCpfCnpj(campo) {
    var vr = campo.value;

    if (vr.length > 0) {
        vr = vr.replace(new RegExp("\\.", "gm"), "").replace("-", "").replace("/", "");
    }
    var tam = vr.length;
    if ((tam == 11)) {
        campo.value = vr.substr(0, tam - 8) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
    }
    if (tam >= 14) { //00.000.000.000/0000-00 01.234.567.890/1234-56
        campo.value = vr.substr(0, 2) + '.' + vr.substr(2, 3) + '.' + vr.substr(5, 3) + '/' + vr.substr(8, 4) + '-' + vr.substr(12, tam);
    }
};

function formataValorCpf(campo) {
    var vr = campo.value;
    if (vr.length > 0) {
        vr = vr.replace(new RegExp("\\.", "gm"), "").replace("-", "");
    }

    tam = vr.length;
    if (tam <= 2) {
        campo.value = vr;
    }
    if ((tam > 2) && (tam <= 5)) {
        campo.value = vr.substr(0, tam - 2) + '-' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 6) && (tam <= 8)) {
        campo.value = vr.substr(0, tam - 5) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
    }
    if ((tam == 11)) {
        campo.value = vr.substr(0, tam - 8) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
    }
};

function formataValorCnpj(campo) {
    var vr = campo.value;
    if (vr.length > 0) {
        vr = vr.replace(new RegExp("\\.", "gm"), "").replace("-", "").replace("/", "");
    }

    tam = vr.length;
    //00.000.000.000/0000-00 01.234.567.890/1234-56
    if (tam <= 2) {
        campo.value = vr;
    }
    if ((tam > 2) && (tam <= 5)) {
        campo.value = vr.substr(0, tam - 2) + '-' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 6) && (tam <= 8)) {
        campo.value = vr.substr(0, tam - 6) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 9) && (tam <= 11)) {
        campo.value = vr.substr(0, tam - 9) + '.' + vr.substr(tam - 9, 3) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
    }
    if ((tam >= 9) && (tam <= 11)) {
        campo.value = vr.substr(0, tam - 9) + '.' + vr.substr(tam - 9, 3) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
    }
    if (tam >= 14) { //00.000.000.000/0000-00 01.234.567.890/1234-56
        campo.value = vr.substr(0, 2) + '.' + vr.substr(2, 3) + '.' + vr.substr(5, 3) + '/' + vr.substr(8, 4) + '-' + vr.substr(12, tam);
    }
};

function TrataPaste(este, e, tipo) {
    var texto = e.clipboardData.getData('text').replace(new RegExp("\\.", "gm"), "").replace("-", "").replace("/", "");
    var isnum = /^\d+$/.test(texto);
    debugger;

    if (isnum == false) {
        e.preventDefault();
        return;

    }
    var caixa = document.getElementById(tipo);
    teste.value = texto;

    switch (tipo) {
        case 'cpf':
            formataValorCpf(caixa);
            break;
        case 'cnpj':
            formataValorCnpj(caixa);
            break;
        case 'cpfCnpj':
            formataValorCpfCnpj(caixa);
            break;
    }

    e.preventDefault();
};


const handleZipCode = (event) => {
    let input = event.target
    input.value = zipCodeMask(input.value)
}

const zipCodeMask = (value) => {
    if (!value) return ""
    value = value.replace(/\D/g, '')
    value = value.replace(/(\d{5})(\d)/, '$1-$2')
    return value
}
const input = document.getElementById("cnpj");
input.addEventListener("keyup", formatarCNPJ);

function formatarCNPJ(e) {

    var v = e.target.value.replace(/\D/g, "");

    v = v.replace(/^(\d{2})(\d)/, "$1.$2");

    v = v.replace(/^(\d{2})\.(\d{3})(\d)/, "$1.$2.$3");

    v = v.replace(/\.(\d{3})(\d)/, ".$1/$2");

    v = v.replace(/(\d{4})(\d)/, "$1-$2");

    e.target.value = v;



}