

$(document).ready(function () {

    traerClientes();

    function traerClientes() {

        $("#tb_body_cliente").html('');

        $.ajax({
            url: '../Api/Cliente/clientes',
            method: "GET",
            beforeSend: function () {
                console.log("Antes del envio");
            },
            success: function (data) {

                let listaClientes = ``;

                if (data != null || data != '' || data != undefined) {

                    data.forEach(item => {

                        listaClientes += `<tr class="">
                            <td class="text-left">` + item.nombres + `</td>
                            <td class="text-left">` + item.ap_paterno + ` ` + item.ap_materno + `</td>
                            <td class="text-center">` + item.nro_documento + `</td>
                            <td class="text-center">` + item.correo + `</td>
                            <td class="text-center">` + item.nro_contacto + `</td>
                            <td class="text-center"><a class="btn btn-success btn-sm" href="/Cliente/Editar/` + item.id + `" >Editar</a></td>
                            <td class="text-center"><button class="btn btn-danger btn-sm eliminar" id="eliminar` + item.id + `">Eliminar</button></td>
                        </tr>`;
                    });
                }
                $("#tb_body_cliente").html(listaClientes);
                callEventos();
            }
        });

    }

    

    function callEventos() {
        $(".eliminar").click(function (event) {

            event.preventDefault();

            let decision = confirm("¿Desea Eliminar al cliente?");


            if (decision) {

                let mi_id = $(this).attr("id");


                $.ajax({
                    url: './Api/Cliente/eliminar/' + mi_id,
                    method: "POST",
                    data: { id: mi_id },
                    dataType: "json",
                    beforeSend: function () {
                        console.log("Antes del envio", mi_id);
                    },
                    success: function (data) {

                        console.log(data);

                        traerClientes();
                    }
                });
               
            }

        });
    }

    

});