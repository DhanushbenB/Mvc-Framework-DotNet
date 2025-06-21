$(document).ready(function () {
    var $table = $("#table2");
    $table.find('thead tr').append('<th>Experience</th>');
    $table.find('thead tr').append('<th>DA</th>');
    $table.find('thead tr').append('<th>HRA</th>');
    $table.find('thead tr').append('<th>TA</th>');
    $table.find('thead tr').append('<th>FA</th>');
    $table.find('thead tr').append('<th>PF</th>');
    $table.find('thead tr').append('<th>Insurance</th>');
    $table.find('thead tr').append('<th>Gross Pay</th>');
    $table.find('thead tr').append('<th>Net Pay</th>');
    $table.find('thead tr').append('<th>Total Deductions</th>');
    $table.find('tbody tr').each(function () {
        var $row = $(this);
        var basicPay = parseFloat($row.find('td:nth-child(3)').text());
        var date = new Date($row.find('td:nth-child(4)').text());
        var year = date.getFullYear();
        var experience =  2024-year;
        if (isNaN(basicPay)) return; 
        var da = basicPay * 0.31;
        var hra = basicPay * 0.10; 
        var ta = basicPay * 0.05; 
        var fa = basicPay * 0.03; 
        var grossPay = basicPay + da + hra + ta + fa;

        var pfRate = (basicPay + da <= 15000) ? 0.083 : 0.12;
        var insuranceRate = (basicPay + da <= 15000) ? 0.03 : 0.05;
        var pf = grossPay * pfRate;
        var insurance = grossPay * insuranceRate;
        var totalDeductions = pf + insurance;

        var netPay = grossPay - totalDeductions;
        $row.append(`<td>${experience} years</td>`);
        $row.append(`<td>${da}</td>`);
        $row.append(`<td>${hra}</td>`);
        $row.append(`<td>${ta}</td>`);
        $row.append(`<td>${fa}</td>`);
        $row.append(`<td>${pf.toFixed(2)}</td>`);
        $row.append(`<td>${insurance.toFixed(2)}</td>`);
        $row.append(`<td>${grossPay.toFixed(2)}</td>`);
        $row.append(`<td>${netPay.toFixed(2)}</td>`);
        $row.append(`<td>${totalDeductions.toFixed(2)}</td>`);
    });
});
