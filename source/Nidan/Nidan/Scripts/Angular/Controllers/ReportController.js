﻿(function () {
    'use strict';

    angular
        .module('Nidan')
        .controller('ReportController', ReportController);

    ReportController.$inject = ['$window', 'ReportService', 'Paging', 'OrderService', 'OrderBy', 'Order', '$uibModal'];

    function ReportController($window, ReportService, Paging, OrderService, OrderBy, Order, $uibModal) {
        /* jshint validthis:true */
        var vm = this;
        vm.totalSumOfCountReportsByMonth = [];
        vm.totalSumOfCountReportsByDate = [];
        vm.reports = [];
        vm.registrationSummaryReports = [];
        vm.downPaymentSummaryReports = [];
        vm.installmentSummaryReports = [];
        vm.paging = new Paging;
        vm.pageChanged = pageChanged;
        vm.orderBy = new OrderBy;
        vm.order = order;
        vm.orderClass = orderClass;
        vm.searchKeyword = "";
        vm.searchMessage = "";
        vm.centreId;
        vm.fromYear;
        vm.date;
        vm.initialise = initialise;
        //vm.retrieveEnquiryReports = retrieveEnquiryReports;
        vm.searchEnquiryByDate = searchEnquiryByDate;
        //vm.retrieveMobilizationReports = retrieveMobilizationReports;
        vm.searchMobilizationByDate = searchMobilizationByDate;
        //vm.retrieveFollowUpReports = retrieveFollowUpReports;
        vm.searchFollowUpByDate = searchFollowUpByDate;
        vm.downloadEnquiryCSVByDate = downloadEnquiryCSVByDate;
        vm.searchAdmissionByDate = searchAdmissionByDate;
        vm.searchRegistrationByDate = searchRegistrationByDate;
        vm.searchCounsellingByDate = searchCounsellingByDate;
        vm.searchExpenseByDate = searchExpenseByDate;
        vm.searchStockByDate = searchStockByDate;
        vm.searchMobilizationCountReportBydate = searchMobilizationCountReportBydate;
        vm.searchMobilizationCountReportByToday = searchMobilizationCountReportByMonth;
        vm.searchMobilizationCountReportByMonthAndYear = searchMobilizationCountReportByMonthAndYear;
        vm.searchFixAssetByDate = searchFixAssetByDate;
        vm.downloadEnquiryCSVByDate = downloadEnquiryCSVByDate;
        vm.downloadMobilizationCSVByDate = downloadMobilizationCSVByDate;
        vm.downloadFollowUpCSVByDate = downloadFollowUpCSVByDate;
        vm.downloadAdmissionCSVByDate = downloadAdmissionCSVByDate;
        vm.downloadRegistrationCSVByDate = downloadRegistrationCSVByDate;
        vm.downloadCounsellingCSVByDate = downloadCounsellingCSVByDate;
        vm.downloadExpenseCSVByDate = downloadExpenseCSVByDate;
        vm.downloadFixAssetCSVByDate = downloadFixAssetCSVByDate;
        vm.downloadStockCSVByDate = downloadStockCSVByDate;
        vm.totalSumOfCountByMonth = totalSumOfCountByMonth;
        vm.totalSumOfCountByDate = totalSumOfCountByDate;
        vm.downloadMobilizationCountReportCSVByMonthAndYear = downloadMobilizationCountReportCSVByMonthAndYear;
        vm.downloadMobilizationCountReportCSVByDate = downloadMobilizationCountReportCSVByDate;
        vm.viewMobilizationReportByDate = viewMobilizationReportByDate;
        vm.viewMobilizationReportByMonthWise = viewMobilizationReportByMonthWise;
        vm.viewCandidateFeeByDate = viewCandidateFeeByDate;
        vm.retrieveCandidateFeeByDate = retrieveCandidateFeeByDate;
        vm.retrieveRegistrationSummaryByDate = retrieveRegistrationSummaryByDate;
        vm.retrieveDownPaymentSummaryByDate = retrieveDownPaymentSummaryByDate;
        vm.retrieveInstallmentSummaryByDate = retrieveInstallmentSummaryByDate;

        function initialise() {
            vm.orderBy.property = "ReportId";
            vm.orderBy.direction = "Ascending";
            vm.orderBy.class = "desc";
            order("ReportId");
        }

        //function retrieveEnquiryReports() {
        //    return ReportService.retrieveEnquiryReports(vm.paging, vm.orderBy)
        //        .then(function (response) {
        //            vm.reports = response.data.Items;
        //            vm.paging.totalPages = response.data.TotalPages;
        //            vm.paging.totalResults = response.data.TotalResults;
        //            return vm.reports;
        //        });
        //}

        function searchFixAssetByDate(fromDate, toDate) {
            vm.fromDate = fromDate;
            vm.toDate = toDate;
            vm.orderBy.property = "DateofPurchase";
            vm.orderBy.class = "asc";
            order("DateofPurchase");
            return ReportService.searchFixAssetByDate(vm.fromDate, vm.toDate, vm.paging, vm.orderBy)
                .then(function (response) {
                    vm.reports = response.data.Items;
                    vm.paging.totalPages = response.data.TotalPages;
                    vm.paging.totalResults = response.data.TotalResults;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    return vm.reports;
                });
        }

        function searchEnquiryByDate(fromDate, toDate) {
            vm.fromDate = fromDate;
            vm.toDate = toDate;
            vm.orderBy.property = "EnquiryDate";
            vm.orderBy.class = "asc";
            order("EnquiryDate");
            return ReportService.searchEnquiryByDate(vm.fromDate, vm.toDate, vm.paging, vm.orderBy)
                .then(function (response) {
                    vm.reports = response.data.Items;
                    vm.paging.totalPages = response.data.TotalPages;
                    vm.paging.totalResults = response.data.TotalResults;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    return vm.reports;
                });
        }

        function searchMobilizationByDate(fromDate, toDate) {
            vm.fromDate = fromDate;
            vm.toDate = toDate;
            vm.orderBy.property = "CreatedDate";
            vm.orderBy.class = "asc";
            order("CreatedDate");
            return ReportService.searchMobilizationByDate(vm.fromDate, vm.toDate, vm.paging, vm.orderBy)
                .then(function (response) {
                    vm.reports = response.data.Items;
                    vm.paging.totalPages = response.data.TotalPages;
                    vm.paging.totalResults = response.data.TotalResults;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    return vm.reports;
                });
        }

        //function retrieveFollowUpReports() {
        //    return ReportService.retrieveFollowUpReports(vm.paging, vm.orderBy)
        //        .then(function (response) {
        //            vm.reports = response.data.Items;
        //            vm.paging.totalPages = response.data.TotalPages;
        //            vm.paging.totalResults = response.data.TotalResults;
        //            return vm.reports;
        //        });
        //}

        function searchFollowUpByDate(fromDate, toDate) {
            vm.fromDate = fromDate;
            vm.toDate = toDate;
            vm.orderBy.property = "FollowUpId";
            vm.orderBy.class = "asc";
            order("FollowUpId");
            return ReportService.searchFollowUpByDate(vm.fromDate, vm.toDate, vm.paging, vm.orderBy)
                .then(function (response) {
                    vm.reports = response.data.Items;
                    vm.paging.totalPages = response.data.TotalPages;
                    vm.paging.totalResults = response.data.TotalResults;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    return vm.reports;
                });
        }

        function searchAdmissionByDate(fromDate, toDate) {
            vm.fromDate = fromDate;
            vm.toDate = toDate;
            vm.orderBy.property = "AdmissionDate";
            vm.orderBy.class = "asc";
            order("AdmissionDate");
            return ReportService.searchAdmissionByDate(vm.fromDate, vm.toDate, vm.paging, vm.orderBy)
                .then(function (response) {
                    vm.reports = response.data.Items;
                    vm.paging.totalPages = response.data.TotalPages;
                    vm.paging.totalResults = response.data.TotalResults;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    return vm.reports;
                });
        }

        function searchStockByDate(fromDate, toDate) {
            vm.fromDate = fromDate;
            vm.toDate = toDate;
            vm.orderBy.property = "StockPurchaseDate";
            vm.orderBy.class = "asc";
            order("StockPurchaseDate");
            return ReportService.searchStockByDate(vm.fromDate, vm.toDate, vm.paging, vm.orderBy)
                .then(function (response) {
                    vm.reports = response.data.Items;
                    vm.paging.totalPages = response.data.TotalPages;
                    vm.paging.totalResults = response.data.TotalResults;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    return vm.reports;
                });
        }

        function searchRegistrationByDate(fromDate, toDate) {
            vm.fromDate = fromDate;
            vm.toDate = toDate;
            vm.orderBy.property = "RegistrationDate";
            vm.orderBy.class = "asc";
            order("RegistrationDate");
            return ReportService.searchRegistrationByDate(vm.fromDate, vm.toDate, vm.paging, vm.orderBy)
                .then(function (response) {
                    vm.reports = response.data.Items;
                    vm.paging.totalPages = response.data.TotalPages;
                    vm.paging.totalResults = response.data.TotalResults;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    return vm.reports;
                });
        }

        function searchCounsellingByDate(fromDate, toDate) {
            vm.fromDate = fromDate;
            vm.toDate = toDate;
            vm.orderBy.property = "CreatedDate";
            vm.orderBy.class = "asc";
            order("CreatedDate");
            return ReportService.searchCounsellingByDate(vm.fromDate, vm.toDate, vm.paging, vm.orderBy)
                .then(function (response) {
                    vm.reports = response.data.Items;
                    vm.paging.totalPages = response.data.TotalPages;
                    vm.paging.totalResults = response.data.TotalResults;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    return vm.reports;
                });
        }

        function searchExpenseByDate(fromDate, toDate) {
            vm.fromDate = fromDate;
            vm.toDate = toDate;
            vm.orderBy.property = "ExpenseCreatedDate";
            vm.orderBy.class = "asc";
            order("ExpenseCreatedDate");
            return ReportService.searchExpenseByDate(vm.fromDate, vm.toDate, vm.paging, vm.orderBy)
                .then(function (response) {
                    vm.reports = response.data.Items;
                    vm.paging.totalPages = response.data.TotalPages;
                    vm.paging.totalResults = response.data.TotalResults;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    return vm.reports;
                });
        }

        function searchMobilizationCountReportBydate(centreId, fromMonth, fromYear) {
            vm.centreId = centreId == undefined ? getUrlParameter("centreId") : centreId;
            vm.fromMonth = fromMonth == undefined ? getUrlParameter("month") : fromMonth;
            vm.fromYear = fromYear == undefined ? getUrlParameter("year") : fromYear;

            return ReportService.searchMobilizationCountReportBydate(vm.centreId, vm.fromMonth, vm.fromYear)
                .then(function (response) {
                    vm.reports = response.data;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    // totalSumOfCountByDate(centreId, fromMonth, fromYear);
                    $('#CentreId').val(vm.centreId);
                    $('#FromMonth').val(vm.fromMonth);
                    $('#FromYear').val(vm.fromYear);
                    return vm.reports;
                });
        }

        function searchMobilizationCountReportByMonth() {
            vm.orderBy.property = "Date";
            vm.orderBy.class = "asc";
            order("Date");
            return ReportService.searchMobilizationCountReportByMonth().then(function (response) {
                    vm.reports = response.data;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    return vm.reports;
                });
        }

        function searchMobilizationCountReportByMonthAndYear(centreId,fromYear) {
            vm.centreId = centreId == undefined ? getUrlParameter("centreId") : centreId;
            vm.fromYear = fromYear == undefined ? getUrlParameter("year") : fromYear;
            vm.orderBy.property = "Month";
            vm.orderBy.class = "asc";
            order("Month");
            return ReportService.searchMobilizationCountReportByMonthAndYear(vm.centreId, vm.fromYear, vm.paging, vm.orderBy)
                .then(function (response) {
                    vm.reports = response.data;
                    vm.searchMessage = vm.reports.length === 0 ? "No Records Found" : "";
                    totalSumOfCountByMonth(centreId, fromMonth, toMonth, fromYear, toYear);
                    return vm.reports;
                });
        }

        function pageChanged() {
            vm.centreId = $("#CentreId").val();
            vm.fromDate = $("#fromDate").val();
            vm.toDate = $("#toDate").val();
            vm.fromMonth = $("#FromMonth").val();
            vm.toMonth = $("#ToMonth").val();
            vm.fromYear = $("#FromYear").val();
            vm.toYear = $("#ToYear").val();
            var path = window.location.pathname.split('/');
            if (path[2] == "Enquiry") {
                searchEnquiryByDate(vm.fromDate, vm.toDate);
            }
            if (path[2] == "Mobilization") {
                searchMobilizationByDate(vm.fromDate, vm.toDate);
            }
            if (path[2] == "FollowUp") {
                searchFollowUpByDate(vm.fromDate, vm.toDate);
            }
            if (path[2] == "Admission") {
                searchAdmissionByDate(vm.fromDate, vm.toDate);
            }
            if (path[2] == "Registration") {
                searchRegistrationByDate(vm.fromDate, vm.toDate);
            }
            if (path[2] == "Counselling") {
                searchCounsellingByDate(vm.fromDate, vm.toDate);
            }
            if (path[2] == "MobilizationProcessReportByDate") {
                searchMobilizationCountReportBydate(vm.centreId, vm.fromMonth, vm.fromYear);
            }
            if (path[2] == "MobilizationProcessReportByMonth") {
                searchMobilizationCountReportByMonthAndYear(vm.centreId, vm.fromMonth, vm.toMonth, vm.fromYear, vm.toYear);
            }
            if (path[2] == "searchFixAssetByDate") {
                searchFixAssetByDate(vm.fromDate, vm.toDate);
            }
        }

        function downloadFixAssetCSVByDate(fromDate, toDate) {
            return ReportService.downloadFixAssetCSVByDate(fromDate, toDate);
        }

        function downloadMobilizationCSVByDate(fromDate, toDate) {
            return ReportService.downloadMobilizationCSVByDate(fromDate, toDate);
        }

        function downloadFollowUpCSVByDate(fromDate, toDate) {
            return ReportService.downloadFollowUpCSVByDate(fromDate, toDate);
        }

        function downloadAdmissionCSVByDate(fromDate, toDate) {
            return ReportService.downloadAdmissionCSVByDate(fromDate, toDate);
        }

        function downloadRegistrationCSVByDate(fromDate, toDate) {
            return ReportService.downloadRegistrationCSVByDate(fromDate, toDate);
        }

        function downloadCounsellingCSVByDate(fromDate, toDate) {
            return ReportService.downloadCounsellingCSVByDate(fromDate, toDate);
        }

        function downloadExpenseCSVByDate(fromDate, toDate) {
            return ReportService.downloadExpenseCSVByDate(fromDate, toDate);
        }

        function downloadMobilizationCountReportCSVByMonthAndYear(centreId,fromYear) {
            return ReportService.downloadMobilizationCountReportCSVByMonthAndYear(centreId,fromYear);
        }

        function downloadMobilizationCountReportCSVByDate(centreId, month, year) {
            return ReportService.downloadMobilizationCountReportCSVByDate(centreId, month, year);
        }

        function downloadEnquiryCSVByDate(fromDate, toDate) {
            return ReportService.downloadEnquiryCSVByDate(fromDate, toDate);
        }

        function downloadStockCSVByDate(fromDate, toDate) {
            return ReportService.downloadStockCSVByDate(fromDate, toDate);
        }

        function order(property) {
            vm.orderBy = OrderService.order(vm.orderBy, property);
        }

        function orderClass(property) {
            return OrderService.orderClass(vm.orderBy, property);
        }

        function totalSumOfCountByMonth(centreId, fromMonth, toMonth, fromYear, toYear) {
            return ReportService.totalSumOfCountByMonth(centreId, fromMonth, toMonth, fromYear, toYear).then(function (response) {
                vm.totalSumOfCountReportsByMonth = response.data;
                return vm.totalSumOfCountReportsByMonth;
            });
        }

        function retrieveCandidateFeeByDate(centreId,date) {
            vm.centreId = centreId == undefined ? getUrlParameter("centreId") : centreId;
            vm.date = date == undefined ? getUrlParameter("date") : date;
            return ReportService.retrieveCandidateFeeByDate(vm.centreId, vm.date).then(function (response) {
                vm.reports = response.data;
                return vm.reports;
            });
        } 

        function retrieveRegistrationSummaryByDate(centreId, date) {
            vm.centreId = centreId;
            vm.date = date;
            return ReportService.retrieveRegistrationSummaryByDate(vm.centreId, vm.date).then(function (response) {
                vm.registrationSummaryReports = response.data.Items;
                return vm.registrationSummaryReports;
            });
        } 

        function retrieveDownPaymentSummaryByDate(centreId, date) {
            vm.centreId = centreId;
            vm.date = date;
            return ReportService.retrieveDownPaymentSummaryByDate(vm.centreId, vm.date).then(function (response) {
                vm.downPaymentSummaryReports = response.data.Items;
                return vm.downPaymentSummaryReports;
            });
        }

        function retrieveInstallmentSummaryByDate(centreId, date) {
            vm.centreId = centreId;
            vm.date = date;
            return ReportService.retrieveInstallmentSummaryByDate(vm.centreId, vm.date).then(function (response) {
                vm.installmentSummaryReports = response.data.Items;
                return vm.installmentSummaryReports;
            });
        }

        function totalSumOfCountByDate(centreId, fromMonth, fromYear) {
            return ReportService.totalSumOfCountByDate(centreId, fromMonth, fromYear).then(function (response) {
                vm.totalSumOfCountReportsByDate = response.data;
                return vm.totalSumOfCountReportsByDate;
            });
        }

        function viewMobilizationReportByDate(centreId, fromMonth, fromYear) {
            window.location.href = "/Report/MobilizationProcessReportByDate?centreId=" +centreId + "&month=" + fromMonth + "&year=" + fromYear;
        }

        function viewCandidateFeeByDate(centreId,date) {
            window.location.href = "/Report/FeeSummaryByDate?centreId=" + centreId + "&date=" + date;
        }

        function viewMobilizationReportByMonthWise(centreId, fromYear) {
            vm.centreId = centreId;
            vm.fromYear = fromYear;
            window.location.href = "/Report/MobilizationProcessReportByMonth?centreId=" + centreId + "&year=" + fromYear;
        }

       function getUrlParameter(sParam) {
            var sPageURL = decodeURIComponent(window.location.search.substring(1)),
                sURLVariables = sPageURL.split('&'),
                sParameterName,
                i;

            for (i = 0; i < sURLVariables.length; i++) {
                sParameterName = sURLVariables[i].split('=');

                if (sParameterName[0] === sParam) {
                    return sParameterName[1] === undefined ? true : sParameterName[1];
                }
            }
        }
    }

})();
