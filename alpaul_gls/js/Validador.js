function WebForm_OnSubmit() {
    if (typeof (ValidatorOnSubmit) == "function" && ValidatorOnSubmit() == false) {
        var UltimoEstatus = '';
        var UltimoControl = '';

        for (var i in Page_Validators) {
            try {
                var validar = Page_Validators[i];
                var control = document.getElementById(Page_Validators[i].controltovalidate);

                //control.readOnly = 'readonly';
                //Page_ValidationActive = false;
                //document.getElementById(validar.id).enabled = false;
                //document.getElementById(validar.id).EnableClientScript = false;
                //document.getElementById(validar).style.display = "none";

                if (UltimoControl != control.id) {
                    UltimoControl = control.id;
                    UltimoEstatus = Page_Validators[i].isvalid;
                }

                if (UltimoControl == control.id && UltimoEstatus == validar.isvalid) {
                    if (UltimoEstatus == false) {
                        control.className = control.className.concat(" ctrl-error");
                    } else { control.classList.remove("ctrl-error"); }
                }
                else if (UltimoControl == control.id && UltimoEstatus != validar.isvalid) {
                    control.className = control.className.concat(" ctrl-error");
                }
            } catch (e) { }
        }
        return false;
    }
    return true;
}
