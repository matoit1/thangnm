$(function() {

	$('#checkall').click(function() {

		if ($(this).is(':checked')) {
			$('.checkaction').prop("checked", true);
		} else {
			$('.checkaction').prop('checked', false);

		}
	});

	$('#abc').click(function() {
		alert('123');
		$('j_idt53\\:uploadFile').click();
	});

	$('#myTab a').click(function(e) {
		e.preventDefault();
		$(this).tab('show');
	});
	// $('.datepicker').datepicker();

	/*
	 * $('[data-toggle="modal"]').click(function(e) { e.preventDefault(); var
	 * url = $(this).attr('href'); if (url.indexOf('#') == 0) {
	 * $(url).modal('open'); } else { $.get(url, function(data) {
	 * $('#imodal').html(data); jQuery("span.timeago").timeago();
	 * $('#imodal').modal(); }).success(function() {
	 * $('input:text:visible:first').focus();
	 * 
	 * }); }
	 * 
	 * });
	 */
	$('[data-toggle="modal_ajax"]').click(function(e) {
		e.preventDefault();
		var $modal = $('#ajax-modal');
		var url = $(this).attr('href');
		$('body').modalmanager('loading');
		setTimeout(function() {
			$modal.load(url, '', function() {
				$modal.modal();
			});
		}, 1000);
	});
	jQuery("span.timeago").timeago();
	jQuery("#formID3").validationEngine('attach', {
		promptPosition : "bottomRight",
		autoPositionUpdate : true
	});
	jQuery("#formID2").validationEngine('attach', {
		promptPosition : "bottomRight",
		autoPositionUpdate : true
	});
	
	jQuery("#checkAll").change(function () {
		var list = jQuery("input[name='tuitionPlan[]']"); 
		var checked_status = this.checked;
		var sotinchi = 0;
			jQuery.each( list, function( i, val ) {
				list[i].checked = checked_status;
				if(list[i].checked==true)
				sotinchi = sotinchi + list[i].title*1;
			});
		jQuery("#form\\:sotinchi").val(parseFloat(sotinchi));
		jQuery("#form\\:sotien").val(parseFloat(sotinchi*210000));
		
	});

	jQuery("input[name='tuitionPlan[]']").click(function () {
		var list = jQuery("input[name='tuitionPlan[]']"); 
		var sotinchi = 0;
			jQuery.each( list, function( i, val ) {
				if(list[i].checked==true)
				sotinchi = sotinchi + list[i].title*1;
			});
		jQuery("#form\\:sotinchi").val(parseFloat(sotinchi));
		jQuery("#form\\:sotien").val(parseFloat(sotinchi*210000));
	});

	/*
	 * $(".datepicker").datepicker({ format: 'dd-mm-yyyy' });
	 */
	/*
	 * $( "#inline-datepicker" ).datepicker();
	 * 
	 * var d = date.getDate(); var m = date.getMonth(); var y =
	 * date.getFullYear();
	 * 
	 * $('#calendar').fullCalendar({ theme: true, header: { left: 'prev,next
	 * today', center: 'title', right: 'month,agendaWeek,agendaDay' }, editable:
	 * true, events: [ { title: 'Long Event', start: new Date(y, m, d-5), end:
	 * new Date(y, m, d-2) }, { id: 999, title: 'Repeating Event', start: new
	 * Date(y, m, d-3, 16, 0), allDay: false }, { id: 999, title: 'Repeating
	 * Event', start: new Date(y, m, d+4, 16, 0), allDay: false }, { title:
	 * 'Meeting', start: new Date(y, m, d, 10, 30), allDay: false }, { title:
	 * 'Lunch', start: new Date(y, m, d, 12, 0), end: new Date(y, m, d, 14, 0),
	 * allDay: false }, { title: 'Birthday Party', start: new Date(y, m, d+1,
	 * 19, 0), end: new Date(y, m, d+1, 22, 30), allDay: false }, { title:
	 * 'Click for Google', start: new Date(y, m, 28), end: new Date(y, m, 29),
	 * url: 'http://google.com/' } ] });
	 */
}

);
