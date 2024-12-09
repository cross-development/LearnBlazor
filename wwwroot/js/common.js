window.showToaster = function (type, message) {
    if (type === "success") {
        toastr?.success(message);
    }

    if (type === "error") {
        toastr?.error(message);
    }
}

window.showSwal = function (type, title, message) {
    Swal.fire({ title, text: message, icon: type });
}