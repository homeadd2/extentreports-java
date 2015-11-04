﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevantCodes.ExtentReports.View
{
    internal class Extent
    {
        public static string Source
        {
            get
            {
                return @"
                    <!DOCTYPE html>
                    <html>
                        <head>
                            <!--
                                ExtentReports Library 2.40.0 | http://relevantcodes.com/extentreports-for-selenium/ | https://github.com/anshooarora/
                                Copyright (c) 2015, Anshoo Arora (Relevant Codes) | Copyrights licensed under the New BSD License | http://opensource.org/licenses/BSD-3-Clause
                                Documentation: http://extentreports.relevantcodes.com 
                            -->
                            <meta http-equiv='content-type' content='text/html; charset=utf-8' /> 
                            <meta name='description' content='ExtentReports (by Anshoo Arora) is a reporting library for automation testing for .NET and Java. It creates detailed and beautiful HTML reports for modern browsers. ExtentReports shows test and step summary along with dashboards, system and environment details for quick analysis of your tests.' />
                            <meta name='robots' content='noodp, noydir' />
                            <meta name='viewport' content='width=device-width, initial-scale=1' />
                            <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css' type='text/css'>
                            <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.1/css/materialize.min.css' type='text/css'>
                            <link href='https://cdn.rawgit.com/noelboss/featherlight/1.3.4/release/featherlight.min.css' type='text/css' rel='stylesheet' />
                            <title>ExtentReports 2.40</title>
                            <style type='text/css'>
                                body {
                                    background: #eff2f8;
                                    font-size: 13px;
                                }
                                pre {
                                    border: 1px solid #ebedef;
                                    border-radius: 4px;
                                    background-color: #f8f9fa;
                                    color: #222 !important;
                                    font-family: Consolas, monospace;
                                    font-size: 13px;
                                    margin: 0;
                                    padding: 7px 10px;
                                    white-space: pre-wrap;
                                }
                                img {
                                    display: block;
                                    margin-top: 15px;
                                }
                                th, td {
                                    border-bottom: 1px solid #ddd !important;
                                    color: #222 !important;
                                }
                                th {
                                    font-family: Roboto, Arial;
                                    font-size: 11px;
                                    font-weight: 500 !important;
                                    padding: 7px 10px;
                                    text-transform: uppercase;
                                }
                                td {
                                    font-size: 13px;
                                    font-weight: 400;
                                    padding: 7px 10px;
                                    word-break: break-all;
                                }
        
                                /* -- [ containers ] -- */
                                .container {
                                    max-width: none;
                                    padding-left: 70px;
                                    padding-bottom: 100px;
                                    padding-top: 5px;
                                    width: 98%;
                                }
                                .wrapper {
                                    background: #fff;
                                    height: 100%;
                                    overflow: auto;
                                }
            
                                /* -- [ material overrides ] -- */
                                .z-depth-1, nav, .card-panel, .card, .toast, .btn, .btn-large, .btn-floating, .dropdown-content, .collapsible, .side-nav {
                                    box-shadow: none;
                                }
                                [type='checkbox']:checked + label::before {
                                    border-color: transparent #eee #eee transparent;
                                    left: 0;
                                }
                                [type='checkbox'] + label::before {
                                    border: 2px solid #ddd;
                                    left: 7px;
                                    margin-top: 4px;
                                }
                                .select-wrapper input.select-dropdown, .input-field label {
                                    font-size: 0.8rem;
                                }
                                .material-tooltip, label {
                                    font-size: 13px !important;
                                }
                                .input-field label {
                                    font-size: 11px !important;
                                    left: 0;
                                }
            
                                /* -- [ global structure ] -- */
                                .vh100 {
                                    height: 100vh;
                                }
                                .capitalize {
                                    text-transform: capitalize !important;
                                }
                                .upper {
                                    text-transform: uppercase !important;
                                }
                                .weight-light {
                                    font-weight: 400;
                                }
                                .weight-normal {
                                    font-weight: 500;
                                }
                                .weight-bold {
                                    font-weight: 700;
                                }
                                .text-white {
                                    color: #fff !important;
                                }
                                .no-padding {
                                    padding: 0 !important;
                                }
                                .no-padding-h {
                                    padding-left: 0 !important;
                                    padding-right: 0 !important;
                                }
                                .no-padding-v {
                                    padding-bottom: 0 !important;
                                    padding-top: 0 !important;
                                }
                                .no-margin-v {
                                    margin-bottom: 0 !important;
                                    margin-top: 0 !important;
                                }
                                .no-box-shadow {
                                    box-shadow: none !important;
                                }
                                .pink-accent {
                                    background: #f96868 !important;
                                }
                                .green-accent {
                                    background: #53d192 !important;
                                }
                                .cyan, .light-blue, .deep-orange, .blue, .pink-accent, .green-accent {
                                    color: #fff;
                                }
                                .card {
                                    height: 100px;
                                    padding: 12px 15px;
                                }
                                .card-panel .panel-lead {
                                    margin-top: 70px;
                                }
                                .panel-lead {
                                    display: block;
                                    font-size: 20px;
                                    text-align: center;
                                }
                                .card .panel-lead {
                                    bottom: 10px;
                                    font-size: 15px;
                                    position: absolute;
                                    right: 15px;
                                }
                                .panel-setting {
                                    margin-top: -20px;
                                    padding: 0 5px;
                                }
                                .panel-setting:hover {
                                    background-color: #eee;
                                    border-radius: 5px;
                                    cursor: pointer;
                                }
                                .panel-setting i {
                                    color: #444;
                                }
                                .chart {
                                    height: 100px;
                                    margin: 10px auto 25px;
                                    position: relative;
                                    text-align: center;
                                    width: 100px;
                                }
                                .chart canvas {
                                    position: absolute;
                                    top: 0;
                                    left: 0;
                                }
                                img.active {
                                    max-width: inherit !important;
                                }
                                .linked {
                                    color: #039be5;
                                    cursor: pointer;
                                }
            
                                /* -- [ top-nav ] -- */
                                nav, .side-nav {
                                    box-shadow: 0 1px 3px 0 rgba(0, 0, 0, 0.08), 0 2px 4px 0 rgba(0, 0, 0, 0.08);
                                }
                                nav {
                                    padding-left: 70px;
                                }
                                nav, nav .nav-wrapper i, nav a.button-collapse, nav a.button-collapse i, .logo a, nav label {
                                    background: #00BCD4;
                                    color: #fff;
                                    height: 48px;
                                    line-height: 46px;
                                }
                                nav ul li:hover {
                                    background: none;
                                }
                                .nav-right {
                                    margin-right: 35px;
                                }
                                .nav-right li {
                                    border-left: 1px solid #15d1e9;
                                    font-size: 12px;
                                    padding: 0 10px;
                                }
                                .nav-right li:first-child {
                                    border-left: none;
                                }
                                .nav-right li:last-child {
                                    border-right: 1px solid #15d1e9;
                                    margin-right: -12px;
                                }
                                .report-name {
                                    display: inline-block;
                                    padding-left: 25px;
                                }
            
                                /* -- [ side-nav ] -- */
                                .side-nav {
                                    background: #fff;
                                    width: 70px;
                                }
                                .side-nav li {
                                    display: block;
                                }
                                .side-nav .active, .side-nav .active, .analysis:hover {
                
                                }
                                .side-nav a, .side-nav label, .analysis i {
                                    font-size: 13px !important;
                                }
                                .analysis i {
                                    padding-right: 15px;
                                }
                                .side-nav .menu-toggle {
                                    background: #25cbe3;
                                    cursor: pointer;
                                    margin-right: -15px;
                                    padding: 0 24px !important;
                                }
                                .logo {
                                    background: #00bcd4;
                                    height: 48px;
                                }
                                .logo:hover {
                                    background: #00bcd4 !important;
                                }
                                .logo a {
                                    color: #fff !important;
                                }
                                .logo i {
                                    margin-top: 10px;
                                    padding: 0;
                                }
            
                                /* -- [ dashboard ] -- */
                                #test-analysis, #step-analysis {
                                    height: 130px;
                                    margin: 30px auto 0;
                                    text-align: center;
                                    width: 160px;
                                }
                                .fh .card-panel {
                                    height: 275px;
                                    max-height: 275px;
                                    min-height: 275px;
                                }
                                .chart > div {
                                    text-align: center;
                                }
                                .suite-start-time {
                                    padding-right: 0 !important;
                                }
                                .suite-end-time {
                                    padding-left: 0 !important;
                                }
                                .suite-start-time .card {
                                    border-bottom-right-radius: 0;
                                    border-top-right-radius: 0;
                                }
                                .suite-end-time .card {
                                    border-bottom-left-radius: 0;
                                    border-top-left-radius: 0;
                                }
                                #dashboard-view .progress {
                                    margin-top: 100px;
                                }
                                .chart-box {
                                    display: block;
                                    margin: 0 auto 20px;
                                    text-align: center;
                                }
                                .doughnut-legend li span {
                                    border-radius: 2px;
                                    display: block;
                                    float: left;
                                    height: 10px;
                                    margin-right: 8px;
                                    margin-top: 4px;
                                    width: 10px;
                                }
                                .doughnut-legend {
                                    display: inline-block;
                                    list-style: none;
                                    margin: 10px 0 0 -35px;
                                    font-size: 12px;
                                }
                                .doughnut-legend li {
                                    text-align: left;
                                }
                                .doughnut-legend li:first-letter {
                                    text-transform: capitalize;
                                }

                                /* -- [ categories-view ] -- */
                                .cat-head, .category-status-counts {
                                    display: inline-block;
                                }
                                #cat-collection .category-status-counts {
                                    float: right;
                                }
                                .category-status > span {
                                    border-radius: 3px;
                                    font-size: 11px;
                                    margin: 0 2px;
                                    padding: 2px 4px;
                                }
                                .category-status-counts .label {
                                    border: 1px solid transparent;
                                    font-size: 11px;
                                    text-transform: uppercase;
                                }
                                .category-item th, .category-item td {
                                    width: 20%;
                                }
                                .category-item th:nth-child(2), .category-item td:nth-child(2) {
                                    width: 60%;
                                }
                                .category-header {
                                    margin-bottom: 20px;
                                }
                                .cat-tests td:first-child {
                                    max-width: 150px;
                                    width: 150px;
                                }
            
                                /* -- [ collections ] -- */
                                #test-collection, #cat-collection {
                                    margin: 0;
                                }
                                .test-collection {
                                    margin-bottom: 0;
                                    position: relative;
                                }
                                .test-collection li, .cat-collection li {
                                    border-bottom: 1px solid #e4e7e9;
                                    padding: 20px;
                                }
            
                                /* -- [ filters ] -- */
                                .filters {
                                    padding-bottom: 1px;
                                }
                                .dropdown-content li > a, .dropdown-content li > span {
                                    font-size: 0.85rem;
                                    line-height: 1.2rem;
                                    padding: 0.5rem 1rem;
                                }
                                .clear {
                                    display: none;
                                }
                                .validate.valid + .clear {
                                    cursor: pointer;
                                    display: block;
                                    font-size: 20px;
                                    position: absolute;
                                    right: 0px;
                                    top: 10px;
                                }
            
                                /* -- [ test ] -- */
                                #dashboard-view:not(.hide) + #test-view {
                                    margin-top: -20px;
                                }
                                .test.active, .category-item.active {
                                    border-left: 3px solid #dd4f6a;
                                    color: #444 !important;
                                    /*background: #e8eefa !important;*/
                                }
                                .test .test-body, .cat-collection .cat-body {
                                    display: none;
                                }
                                .test-info {
                                    margin: 5px 0 10px;
                                }
                                .test-name {
                                    display: inline-block;
                                    width: 80% !important;
                                    word-break: break-all;
                                }
                                .test-desc {
                                    margin-bottom: 10px;
                                }
                                .test-steps, .cat-tests {
                                    margin-top: 50px;
                                }
                                .collapsible-body .test-steps {
                                    margin-top: 30px;
                                }
                                .test-steps th:nth-child(2), .test-steps td:nth-child(2) {
                                    max-width: 90px;
                                    width: 90px;
                                }
                                .test-steps th:first-child, .test-steps td:first-child {
                                    text-align: left !important;
                                    max-width: 65px;
                                    width: 35px;
                                }
                                .report-img {
                                    border: 4px solid #f6f7fa;
                                    cursor: zoom-in;
                                    width: 150px;
                                }
                                .test-body .collapsible-header {
                                    background-color: inherit;
                                    border-bottom: none;
                                    height: auto;
                                    line-height: inherit;
                                    padding: 1.2rem 1rem;
                                }
                                .test-body table {
                                    margin-top: 10px;
                                }
                                .test-body table thead tr:first-child {
                                    border-bottom: 2px solid #cacaca;
                                }
                                .test-body .collapsible-body {
                                    padding: 0 15px 30px;
                                    width: 100%;
                                }
                                .test-body .collapsible-body table {
                                    margin-top: -20px;
                                }
                                .test-body .collapsible {
                                    border: none !important;
                                    box-shadow: none !important;
                                }
                                .test-body .collapsible > li.active {
                                    border: 1px solid #999;
                                    background: #fff;
                                    box-shadow: 0 2px 5px 0 rgba(0, 0, 0, 0.16), 0 2px 10px 0 rgba(0, 0, 0, 0.12);
                                }
                                .collapsible .test-info {
                                    margin: 0 0 0 20px;
                                }
                                .test-body .collapsible > li {
                                    background: #edf3ff;
                                    box-shadow: none;
                                    margin-bottom: 2px;
                                }
                                .test-node-name {
                                    display: inline-block;
                                }
                                .test-node .test-started-time, .test-node  .test-ended-time, .test-node  .test-time-taken {
                                    display: none;
                                }
                                .test-node.active .test-started-time, .test-node.active  .test-ended-time, .test-node.active  .test-time-taken {
                                    display: inline-block;
                                }
                                .node-2x {
                                    margin-left: 20px !important;
                                }
                                .node-3x {
                                    margin-left: 35px  !important;
                                }
                                .node-4x {
                                    margin-left: 50px  !important;
                                }
                                .node-5x {
                                    margin-left: 65px !important;
                                }
                                .node-6x {
                                    margin-left: 80px !important;
                                }
                                .node-7x {
                                    margin-left: 95px !important;
                                }
                                .node-8x {
                                    margin-left: 110px !important;
                                }
            
                                /* -- [ test details ] -- */
                                .test-details-container .test-steps {
                                    display: block !important;
                                }
                                .details-container, .cat-container {
                                    background: #fff none repeat scroll 0 0;
                                    margin: 0 -20px;
                                    padding: 0 20px 75px;
                                }
                                .details-view {
                                    position: absolute;
                                }
                                .pin {
                                    height: 96%;
                                    right: 1%;
                                    overflow-y: auto;
                                    width: 54.5%;
                                }
            
                                /* -- [ test-attributes ] -- */
                                .categories, .authors {
                                    display: inline-block;
                                }
                                span.author, span.category {
                                    border-radius: 12px;
                                    font-size: 12px;
                                    padding: 3px 8px;
                                }
                                span.author {
                                    border: 1px solid #9c27b0;
                                    color: #9c27b0 !important;            
                                }
                                span.category {
                                    border: 1px solid #00aeef;
                                    color: #00aeef !important;
                                    cursor: pointer;
                                }
            
                                /* -- [ status styles ] -- */
                                .status.fail, .fail i {
                                    color: #eb4549;
                                } 
                                .status.fatal, .fatal > i {
                                    color: darkred;
                                }
                                .status.error, .error > i {
                                    color: tomato;
                                } 
                                .status.warning, .warning > i {
                                    color: orange;
                                }
                                .status.pass, .pass > i {
                                    color: #32CD32;
                                }                
                                .status.info, .info > i {
                                    color: #22a1c4;
                                } 
                                .status.skip, .skip > i {
                                    color: #999;
                                }
                                .status.unknown, .unknown > i {
                                    color: #222;
                                }
            
                                /* -- [ labels ] -- */
                                .test-status.label, .status.label {
                                    text-align: center;
                                    padding: 2px 8px;
                                }
                                .label {
                                    border: 1px solid transparent;
                                    border-radius: 2px;
                                    display: inline-block;
                                    font-size: 11px;
                                    font-weight: 500;
                                    padding: 2px 5px;
                                    text-transform: none;
                                }
                                .test.active.pass {
                                    border-left-color: #60b963;
                                }
                                .label.success, .label.pass {
                                    border-color: #60b963;
                                    color: #60b963;
                                }
                                .cat-label {
                                    border: 1px solid transparent;
                                }
                                .cat-pass {
                                    border-color: #46be8a !important;
                                    color: #46be8a;
                                }
                                .test.active.fail {
                                    border-left-color: #c64444;
                                }
                                .test.active.fatal {
                                    border-left-color: rgb(139, 0, 0);
                                }
                                .label.fatal {
                                    border-color: rgb(139, 0, 0);
                                    color: rgb(139, 0, 0);
                                }
                                .label.failure, .label.fail {
                                    border-color: #c64444;
                                    color: #c64444;
                                }
                                .cat-fail {
                                    border-color: #f96868 !important;
                                    color: #f96868;
                                }
                                .test.active.error {
                                    border-left-color: #ec407a;
                                }
                                .label.error {
                                    border-color: #ec407a;
                                    color: #ec407a;
                                }
                                .label.info {
                                    border-color: #46BFBD;
                                    color: #46BFBD;
                                }
                                .test.active.warning {
                                    border-left-color: #d88519;
                                }
                                .label.warn, .label.warning {
                                    border-color: #d88519;
                                    color: #d88519;
                                }
                                .cat-other {
                                    border-color: #f2a654 !important;
                                    color: #f2a654;
                                }
                                .test.active.skip {
                                    border-left-color: #2196f3;
                                }
                                .label.skip, .label.skipped {
                                    border-color: #2196f3;
                                    color: #2196f3
                                }
                                .label.unknown {
                                    border-color: #444;
                                    color: #444;
                                }
            
                                /* -- [ media queries ] -- */
                                @media all and (max-width: 992px) {
                                    nav {
                                        padding-left: 1%;
                                    }
                                    header, main, footer, .container {
                                        padding-left: 0;
                                    }
                                }
                            </style>
                        </head>
                        <body class='extent'>  
                            <nav>
                                <ul id='slide-out' class='side-nav fixed'>
                                    <li class='logo'>
                                        <a class='left hide' href='http://extentreports.relevantcodes.com'><span>ExtentReports</span></a>
                                        <a class='menu-toggle right'><i class='fa fa-bars fa-2x'></i></a>
                                    </li> 
                                    <li class='analysis waves-effect active'><a href='#!' class='test-view'><i class='mdi-action-dashboard'></i>Test Details</a></li>
                                    <li class='analysis waves-effect'><a href='#!' class='categories-view'><i class='mdi-maps-local-offer'></i>Categories</a></li>
                                    <li class='analysis waves-effect'><a href='#!' class='dashboard-view'><i class='fa fa-line-chart'></i></i>Analysis</a></li>
                                    <li class='analysis waves-effect'><a href='#!' class='testrunner-logs-view'><i class='mdi-action-assignment'></i>TestRunner Logs</a></li>
                                </ul>
                                <a href='#' data-activates='slide-out' class='button-collapse'><i class='fa fa-bars fa-2x'></i></a>
                                <span class='report-name'>Automation Report</span> <span class='report-headline'></span>
                                <ul class='right hide-on-med-and-down nav-right'>
                                    <li class='test-view-only'>
                                        <input type='checkbox' id='enableDashboard' />
                                        <label for='enableDashboard'>Enable Dashboard</label>
                                    </li>
                                    <li>
                                        <span class='suite-started-time'><!--%SuiteStartedTime%--></span>
                                    </li>
                                    <li>
                                        <span>v2.40.0</span>
                                    </li>
                                </ul>
                            </nav>
                            <div class='container'>
                                <div id='dashboard-view' class='row'>
                                    <div class='time-totals'>
                                        <div class='col l2 m4 s6'>
                                            <div class='card suite-total-tests'> 
                                                <span class='panel-name'>Total Tests</span> 
                                                <span class='total-tests'> <span class='panel-lead'></span> </span> 
                                            </div> 
                                        </div>
                                        <div class='col l2 m4 s6'>
                                            <div class='card suite-total-steps'> 
                                                <span class='panel-name'>Total Steps</span> 
                                                <span class='total-steps'> <span class='panel-lead'></span> </span> 
                                            </div> 
                                        </div>
                                        <div class='col l4 m4 s12'>
                                            <div class='card suite-total-steps'> 
                                                <span class='panel-name'>Total Time Taken</span> 
                                                <span class='suite-total-time-taken panel-lead'></span> 
                                            </div> 
                                        </div>
                                        <div class='col l2 m6 s6 suite-start-time'>
                                            <div class='card green-accent'> 
                                                <span class='panel-name'>Start</span> 
                                                <span class='panel-lead suite-started-time'></span> 
                                            </div> 
                                        </div>
                                        <div class='col l2 m6 s6 suite-end-time'>
                                            <div class='card pink-accent'> 
                                                <span class='panel-name'>End</span> 
                                                <span class='panel-lead suite-ended-time'></span> 
                                            </div> 
                                        </div>
                                    </div>
                                    <div class='charts'>
                                        <div class='col s12 m6 l4 fh'> 
                                            <div class='card-panel'> 
                                                <div>
                                                    <span class='panel-name'>Tests View</span>
                                                </div> 
                                                <div class='panel-setting modal-trigger test-count-setting right'>
                                                    <a href='#test-count-setting'><i class='mdi-navigation-more-vert text-md'></i></a>
                                                </div> 
                                                <div class='chart-box'>
                                                    <canvas class='text-centered' id='test-analysis'></canvas>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='t-pass-count weight-normal'></span> test(s) passed</span>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='t-fail-count weight-normal'></span> test(s) failed, <span class='t-others-count weight-normal'></span> others</span>
                                                </div> 
                                            </div> 
                                        </div> 
                                        <div class='col s12 m6 l4 fh'> 
                                            <div class='card-panel'> 
                                                <div>
                                                    <span class='panel-name'>Steps View</span>
                                                </div> 
                                                <div class='panel-setting modal-trigger step-status-filter right'>
                                                    <a href='#step-status-filter'><i class='mdi-navigation-more-vert text-md'></i></a>
                                                </div> 
                                                <div class='chart-box'>
                                                    <canvas class='text-centered' id='step-analysis'></canvas>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='s-pass-count weight-normal'></span> step(s) passed</span>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='s-fail-count weight-normal'></span> step(s) failed, <span class='s-others-count weight-normal'></span> others</span>
                                                </div> 
                                            </div> 
                                        </div>
                                        <div class='col s12 m12 l4 fh'> 
                                            <div class='card-panel'> 
                                                <span class='panel-name'>Pass Percentage</span> 
                                                <span class='pass-percentage panel-lead'></span> 
                                                <div class='progress light-blue lighten-3'> 
                                                    <div class='determinate light-blue'></div> 
                                                </div> 
                                            </div> 
                                        </div>
                                    </div>
                                    <div class='system-view'>
                                        <div class='col l4 m12 s12'>
                                            <div class='card-panel'>
                                                <span class='label info right'>Environment</span>
                                                <table>
                                                    <thead>
                                                        <tr>
                                                            <th>Param</th>
                                                            <th>Value</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <div class='category-summary-view'>
                                        <div class='col l2 m6 s12'>
                                            <div class='card-panel'>
                                                <span class='label info right'>Categories</span>
                                                <table>
                                                    <thead>
                                                        <tr>
                                                            <th>Name</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id='test-view' class='row'>
                                    <div class='col s5'>
                                        <div class='card-panel filters'>
                                            <div class='input-field no-margin-v'>
                                                <input id='searchTests' type='text' class='validate'>
                                                <span class='clear'><i class='mdi-navigation-close'></i></span>
                                                <label class='active' for='searchTests'>Search Tests..</label>
                                            </div>
                                            <div class='row'>
                                                <div class='col s6'>
                                                    <div class='input-field tests-toggle'>
                                                        <select>
                                                            <option value='0' selected>Choose your option</option>
                                                            <option value='1'>Pass</option>
                                                            <option value='2'>Fatal</option>
                                                            <option value='3'>Fail</option>
                                                            <option value='4'>Error</option>
                                                            <option value='5'>Warning</option>
                                                            <option value='6'>Skip</option>
                                                            <option value='7'>Unknown</option>
                                                            <option value='8'>Clear Filters</option>
                                                        </select>
                                                        <label>Filter By Status</label>
                                                    </div>
                                                </div>
                                                <div class='col s6'>
                                                    <div class='input-field category-toggle'>
                                                        <select>
                                                            <option value='0' selected>Choose your option</option>
                                                            <option value='8'>Clear Filters</option>
                                                        </select>
                                                        <label>Filter By Category</label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class='card-panel no-padding-h no-padding-v'>
                                            <div class='wrapper'>
                                                <ul id='test-collection' class='test-collection'>
                                                    <!--%Test%-->
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div id='test-details-wrapper' class='col s7'>
                                        <div class='card-panel vh100 details-view pin'>
                                            <h5 class='details-name'></h5>
                                            <div class='details-container'>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id='categories-view' class='row hide'>
                                    <div class='col s5'>
                                        <div class='card-panel filters'>
                                            <div class='input-field no-margin-v'>
                                                <input id='searchCats' type='text' class='validate'>
                                                <span class='clear'><i class='mdi-navigation-close'></i></span>
                                                <label class='active' for='searchCats'>Search Categories..</label>
                                            </div>
                                        </div>
                                        <div class='card-panel no-padding-h no-padding-v vh100'>
                                            <div class='wrapper'>
                                                <ul id='cat-collection' class='cat-collection'>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div id='cat-details-wrapper' class='col s7'>
                                        <div class='card-panel vh100 details-view pin'>
                                            <h5 class='cat-name'></h5>
                                            <div class='cat-container'>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id='testrunner-logs-view' class='row hide'>
                                    <div class='col s12'>
                                        <div class='card-panel'>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div id='test-count-setting' class='modal bottom-sheet'> 
                                <div class='modal-content'> 
                                    <h5>Configure Tests Count Setting</h5> 
                                    <input name='test-count-setting' type='radio' id='parentWithoutNodes' class='with-gap'> 
                                    <label for='parentWithoutNodes'>Parent Tests Only (Does not include child nodes in counts)</label> 
                                    <br> 
                                    <input name='test-count-setting' type='radio' id='parentWithoutNodesAndNodes' class='with-gap'> 
                                    <label for='parentWithoutNodesAndNodes'>Parent Tests Without Child Tests + Child Tests</label> 
                                    <br> 
                                    <input name='test-count-setting' type='radio' id='childNodes' class='with-gap'> 
                                    <label for='childNodes'>Child Tests Only</label> 
                                </div> 
                                <div class='modal-footer'> 
                                    <a href='#!' class='modal-action modal-close waves-effect waves-green btn'>Save</a> 
                                </div> 
                            </div> 
                            <div id='step-status-filter' class='modal bottom-sheet'> 
                                <div class='modal-content'> 
                                    <h5>Select status</h5> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-pass'> 
                                    <label for='step-dashboard-filter-pass'>Pass</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-fail'> 
                                    <label for='step-dashboard-filter-fail'>Fail</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-fatal'> 
                                    <label for='step-dashboard-filter-fatal'>Fatal</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-error'> 
                                    <label for='step-dashboard-filter-error'>Error</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-warning'> 
                                    <label for='step-dashboard-filter-warning'>Warning</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-skip'> 
                                    <label for='step-dashboard-filter-skip'>Skipped</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-info'> 
                                    <label for='step-dashboard-filter-info'>Info</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-unknown'> 
                                    <label for='step-dashboard-filter-unknown'>Unknown</label> 
                                </div> 
                                <div class='modal-footer'> 
                                    <a href='#!' class='modal-action modal-close waves-effect waves-green btn'>Save</a> 
                                </div> 
                            </div>
                            <script src='https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js'></script> 
                            <script src='https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.1/js/materialize.min.js'></script>
                            <script src='https://cdnjs.cloudflare.com/ajax/libs/Chart.js/1.0.2/Chart.min.js'></script>
                            <script src='https://cdn.rawgit.com/noelboss/featherlight/1.3.4/release/featherlight.min.js' type='text/javascript' charset='utf-8'></script>
                            <script type='text/javascript'>
                                /* default sidenav width */
                                var menuWidth = 70;
            
                                /* default content container (right-side container) width */
                                var pinWidth = '54.5%';
            
                                /* counts */
                                var totalTests, passedTests, failedTests, fatalTests, warningTests, errorTests, skippedTests, unknownTests;
                                var totalSteps, passedSteps, failedSteps, fatalSteps, warningSteps, errorSteps, infoSteps, skippedSteps, unknownSteps;
            
                                /* global chart instance vars */
                                var testChart, stepChart;
            
                                function hideElement(el) {
                                    el.removeClass('displayed').addClass('hide');
                                }
            
                                function showElement(el) {
                                    el.addClass('displayed').removeClass('hide');
                                }
            
                                $(document).ready(function() {
                                    /* init */
                                    $('.button-collapse').sideNav({ menuWidth: menuWidth });
                                    $('select').material_select();
                                    $('#enableDashboard').prop('checked', false);
                
                                    /* [WINDOW] */
                                    $(window).scroll(function() {
                                        var scrollTop = $('.charts').is(':visible') ? 425 : 100;
                    
                                        if ($(window).scrollTop() > scrollTop) {
                                            var margin = $('.charts').is(':visible') ? '-335px' : '-45px';
                                            $('.details-view').css('position', 'fixed').css('margin-top', margin);
                                        } 
                                        else {
                                            $('.details-view').removeAttr('style').css('position', 'absolute');
                                        }
                    
                                        $('.pin').css('width', pinWidth);
                                    });
                
                                    /* [TOPNAV] */
                                    $('#enableDashboard').click(function() {
                                        $(this).toggleClass('enabled');
                                        $('#dashboard-view').toggleClass('hide').children('div').toggleClass('hide').siblings('.charts').toggleClass('hide');
                                    });
                
                                    /* menu-toggle [SIDE-NAV] */
                                    $('.menu-toggle').click(function() {
                                        menuWidth = menuWidth > 100 ? 70 : 240;
                    
                                        if (pinWidth == '54.5%') { pinWidth = '49.5%'; }
                                        else { pinWidth = '54.5%'; }
                    
                                        $('.logo .left, .side-nav input, .side-nav label').toggleClass('hide');
                    
                                        $('.side-nav').animate({
                                            width: menuWidth + 'px'
                                        }, 200);
                    
                                        $('.container, nav').animate({
                                            'padding-left': menuWidth + 'px'
                                        }, 200);
                    
                                        $('.pin').animate({
                                            'width': pinWidth
                                        }, 200);
                                    });
                
                                    /* side-nav navigation [SIDE-NAV] */
                                    $('.analysis').click(function() {
                                        $('.container > .row, .nav-right > .test-view-only').addClass('hide');
                    
                                        var el = $(this);
                                        var cls = el.children('a').prop('class');
                    
                                        $('#' + cls).removeClass('hide');
                    
                                        if (cls == 'test-view') { 
                                            $('.nav-right > .test-view-only').removeClass('hide');
                        
                                            if ($('#enableDashboard').hasClass('enabled') && !$('#dashboard-view > .charts').is(':visible')) {
                                                $('#enableDashboard').click().prop('checked', true).addClass('enabled');
                                            }
                                        }
                                        else {
                                            $('#dashboard-view > div').removeClass('hide');
                                        }
                    
                                        $('#slide-out > .analysis').removeClass('active');
                                        el.addClass('active');
                                    });
                
                                    /* test-dashboard settings [DASHBOARD] */
                                    $('#dashboard-view .test-count-setting').click(function() {
                                        $('#test-count-setting').openModal();
                                    });
                
                                    /* test count setting */
                                        /* init */
                                        $('#parentWithoutNodesAndNodes').click();
                                    $('#test-count-setting input').click(function() {
                                        $('#test-count-setting').removeClass('parentWithoutNodes parentWithoutNodesAndNodes childNodes');
                                        $('#test-count-setting').addClass($(this).prop('id'));
                                    });
                
                                    /* step-dashboard settings [DASHBOARD] */
                                    $('#dashboard-view .step-status-filter').click(function() {
                                        $('#step-status-filter').openModal();
                                    });
                
                                    /* refresh charts when chart setting is saved */
                                    $('.modal-footer').click(function() {
                                        redrawCharts();
                                    });
                
                                    /* check all checkboxes for step-dashboard filter to allow filtering the steps to be displayed [DASHBOARD] */
                                    $('#step-status-filter input').prop('checked', 'checked');
                                    $('#step-status-filter input').click(function() {
                                       $('#step-status-filter').toggleClass($(this).prop('id').replace('step-dashboard-filter-', ''));
                                    });
                
                                    /* hide category menu if no categories exist [CATEGORIES] */
                                    if ($('.category').length == 0) {
                                        $('#slide-out > .analysis > .categories-view, .category-summary-view').addClass('hide').css('display', 'none');
                                    }
                                    /* view cat info [CATEGORIES] */
                                    $('.category-item').click(function() {
                                        if ($('#cat-details-wrapper .cat-container').find('.cat-body').length > 0) {
                                            $('.category-item').filter(function() {
                                                return ($(this).find('.cat-body').length == 0);
                                            }).append($('#cat-details-wrapper .cat-container').find('.cat-body'));
                                        }
                    
                                        $('#cat-collection .category-item').removeClass('active');
                                        $('#cat-details-wrapper .cat-container .cat-body').remove();
                    
                                        var el = $(this).addClass('active').find('.cat-body');
                                        $('#cat-details-wrapper .cat-name').text($(this).find('.category-name').text());
                                        $('#cat-details-wrapper .cat-container').append($(el));
                                    });
                                    $('.category-item').eq(0).click();
                
                                    /* navigation from cat-view to test-details [CATEGORIES] */
                                    $('.category-link').click(function() {
                                        var id = $(this).attr('extentid');
                                        findTestByNameId($(this).text().trim(), id);
                                    });
                
                                    /* view test info [TEST] */
                                    $('.test').click(function() {
                                        var t = $(this);
                    
                                        if ($('#test-details-wrapper .test-body').length > 0) {
                                            $('#test-collection .test').filter(function() {
                                                return ($(this).find('.test-body').length == 0);
                                            }).append($('#test-details-wrapper .test-body'));
                                        }
                    
                                        $('#test-collection .test').removeClass('active');
                                        $('#test-details-wrapper .test-body').remove();
                    
                                        var el = t.addClass('active').find('.test-body');
                                        $('#test-details-wrapper .details-name').text(t.find('.test-name').text());
                                        $('#test-details-wrapper .details-container').append($(el));
                                    });
                                    $('.test').eq(0).click();
                
                                    /* filter tests by text [TEST] */
                                    $(document).keypress(function(e) {
                                        if(e.which == 13) {
                                            if ($('#searchTests').is(':focus')) {
                                                var txt = $('#searchTests').val().toLowerCase();
                            
                                                hideElement($('#test-collection .test'));
                            
                                                $('.test-name, .test-desc').each(function() {
                                                    var t = $(this);
                                
                                                    if (t.text().toLowerCase().indexOf(txt) >= 0) {
                                                        showElement(t.closest('.test'));
                                                    }
                                                });
                            
                                                $('.test-node-name').each(function() {
                                                    var t = $(this);
                                                    if (t.text().toLowerCase().indexOf(txt) >= 0) {
                                                        showElement(t.closest('.test'));
                                                    }                               
                                                });
                            
                                                $('.details-container .test-node-name').each(function() {
                                                    if ($(this).text().toLowerCase().indexOf(txt) >= 0) {
                                                        showElement($('.test.active'));
                                                    }
                                                });
                            
                                                $('.test:visible').eq(0).click();
                                            }
                                            if ($('#searchCats').is(':focus')) {
                                                var txt = $('#searchCats').val().toLowerCase();
                                                hideElement($('#cat-collection .category-item '));
                            
                                                $('#cat-collection .category-name').each(function() {
                                                    var t = $(this);
                                
                                                    if (t.text().toLowerCase().indexOf(txt) >= 0) {
                                                        showElement(t.closest('.category-item'));
                                                    }
                                                });
                            
                                                $('.category-item:visible').eq(0).click();
                                            }
                                        }
                                    });
                
                                    $('.clear').click(function() {
                                        var t = $(this);
                    
                                        var id = t.prev().val('').attr('id');
                    
                                        if (id == 'searchTests') {
                                            $('#test-collection .test, .test-node').removeClass('hide').addClass('displayed');
                                        }
                                        else {
                                            $('#cat-collection .category-item').removeClass('hide').addClass('displayed');
                                        }
                                        t.next().removeClass('active');
                                        t.prev().removeClass('valid');
                                    });
                
                                    /* if only header row is available for test, hide the table [TEST] */
                                    $('.table-results').filter(function() {
                                        return ($(this).find('tr').length == 1);
                                    }).hide(0);
                
                                    /* clicking a section on pie chart will automatically filter tests by status */
                                    $('#test-analysis').click(
                                        function(evt) {
                                            var label = testChart.getSegmentsAtEvent(evt)[0].label;
                                            $('.tests-toggle li').filter(
                                                function() {
                                                    return ($(this).text() == label);
                                                }
                                            ).click();
                                        }
                                    );
                
                                    /* clicking the category tag will automatically filter tests by category */
                                    $('.category').click(
                                        function(evt) {
                                            var label = $(this).text();
                                            $('.category-toggle li').filter(
                                                function() {
                                                    return ($(this).text() == label);
                                                }
                                            ).click();
                                        }
                                    );
                
                                    /* filter tests by status [TEST] */
                                    $('.tests-toggle li').click(function() {
                                        var opt = $(this).text().toLowerCase();
                                        var opt2 = $('.category-toggle li.active').text().toLowerCase();
                    
                                        if (opt2 == 'choose your option' || opt2 == 'clear filters') {
                                            opt2 = '';
                                        }
                    
                                        if (opt != 'choose your option') {
                                            if (opt == 'clear filters') {
                                                resetFilters();
                                            }
                                            else {
                                                $('.tests-toggle li').removeClass('active');
                                                $(this).addClass('active');
                                                $('.test').hide(0).removeClass('displayed');
                            
                                                if (opt2 != '') {
                                                    $('.test').each(function() {
                                                        var t = $(this);
                                    
                                                        if (t.find('.category-assigned').hasClass(opt2)) {
                                                            if (t.hasClass(opt) || t.has('.test-node.' + opt).length > 0 || (t.hasClass('active') && $('#test-details-wrapper .test-node.' + opt).length > 0)) {
                                                                t.addClass('displayed').show(0);                                        
                                                            }
                                                        }
                                                    });
                                                } 
                                                else {
                                                    var activeTest = '';
                                                    if ($('#test-details-wrapper .test-node.' + opt).length > 0) {
                                                        activeTest = '.test.active,';
                                                    }
                                                    $('.test').hide(0).removeClass('displayed');
                                                    $(activeTest + '.test:has(.test-node.' + opt + '), .test.' + opt).fadeIn(200).addClass('displayed');
                                                }
                            
                                                redrawCharts();
                                            }
                                        }
                                    });
                
                                    /* filter tests by category [TEST] */
                                    $('.category-toggle li').click(function() {
                                        var opt = $(this).text().toLowerCase();
                                        var opt2 = $('.tests-toggle li.active').text().toLowerCase();
                    
                                        if (opt2 == 'choose your option' || opt2 == 'clear filters') {
                                            opt2 = '';
                                        }
                    
                                        if (opt != 'choose your option') {
                                            if (opt == 'clear filters') {
                                                resetFilters();
                                            } 
                                            else {
                                                $('.category-toggle li').removeClass('active');
                                                $(this).addClass('active');
                                                $('.test').hide(0).removeClass('displayed');
                            
                                                if (opt2 != '') {
                                                    $('.test').each(function() {
                                                        var t = $(this);
                                    
                                                        if (t.find('.category-assigned').hasClass(opt)) {
                                                            if (t.hasClass(opt2) || t.has('.test-node.' + opt2).length > 0 || (t.hasClass('active') && $('#test-details-wrapper .test-node.' + opt2).length > 0)) {
                                                                t.addClass('displayed').show(0);                                        
                                                            }
                                                        }
                                                    });
                                                } 
                                                else {
                                                    $('.test').each(function() {
                                                        if ($(this).find('.category-assigned').hasClass(opt)) {
                                                            $(this).fadeIn(200).addClass('displayed');
                                                        }
                                                    });
                                                }
                                                redrawCharts();
                                            }
                                        }                                
                                    });

                                    /* hide testrunner-logs view if no logs added [TESTRUNNER-LOGS] */
                                    if ($('#testrunner-logs-view .card-panel > p').length == 0) {
                                        $('.analysis > .testrunner-logs-view').addClass('hide');
                                    }
                
                                    $('#enableDashboard').click();
                
                                    /* reset test/category filters on document load */
                                    resetFilters();
                                });
            
                                /* action to perform when 'Clear Filters' option is selected [TEST] */
                                function resetFilters() {
                                    $('.dropdown-content li').removeClass('active');
                                    $('.test').addClass('displayed').show(0);
                                    redrawCharts();
                                    $('.dropdown-content li:first-child').addClass('active').click();
                                }
            
                                /* formats date in mm-dd-yyyy hh:mm:ss [UTIL] */
                                function formatDt(d) {
                                    return d.getFullYear() + '-' +
                                        ('00' + (d.getMonth() + 1)).slice(-2) + '-' + 
                                        ('00' + d.getDate()).slice(-2) + ' ' + 
                                        ('00' + d.getHours()).slice(-2) + ':' + 
                                        ('00' + d.getMinutes()).slice(-2) + ':' + 
                                        ('00' + d.getSeconds()).slice(-2);
                                }
            
                                /* finds test by its name and extentId  [UTIL] */
                                function findTestByNameId(name, id) {
                                    $('.test').each(function() {
                                        if ($(this).find('.test-name').text().trim() == name && $(this).attr('extentid') == id) {
                                            $('.analysis > .test-view').click();
                                            $('html, body').animate({
                                                scrollTop: $('.details-name').offset().top
                                            }, 400);
                                            $(this).click();
                                            return;
                                        }
                                    });
                                }
            
                                /* refresh and redraw charts [DASHBOARD] */
                                function redrawCharts() {
                                    if (!$('#dashboard-view .charts').is(':visible')) {
                                        return;
                                    }
                                    refreshData();
                                    testChart.segments[0].value = passedTests;
                                    testChart.segments[1].value = failedTests;
                                    testChart.segments[2].value = fatalTests;
                                    testChart.segments[3].value = errorTests;
                                    testChart.segments[4].value = warningTests;
                                    testChart.segments[5].value = skippedTests;
                                    testChart.segments[6].value = unknownTests;
                                    stepChart.segments[0].value = passedSteps;
                                    stepChart.segments[1].value = infoSteps;
                                    stepChart.segments[2].value = failedSteps;
                                    stepChart.segments[3].value = fatalSteps;
                                    stepChart.segments[4].value = errorSteps;
                                    stepChart.segments[5].value = warningSteps;
                                    stepChart.segments[6].value = skippedSteps;
                                    stepChart.segments[7].value = unknownSteps;
                                    $('#test-analysis, #step-analysis').html('');
                                    $('ul.doughnut-legend').remove();
                                    testsChart();
                                    stepsChart();
                                    $('ul.doughnut-legend').addClass('right');
                                }
            
                                /* update data for dashboard [DASHBOARD] */
                                function refreshData() {
                                    var el = $('#test-count-setting');
                
                                    totalTests = $('.test:not(:has(.test-node)), .test-node').length;
                                    passedTests = $('.details-container .test-node.pass, .test.displayed .test-node.pass, .test.displayed.pass:not(.hasChildren)').length;
                                    failedTests = $('.details-container .test-node.fail, .test.displayed .test-node.fail, .test.displayed.fail:not(.hasChildren)').length;
                                    fatalTests = $('.details-container .test-node.fatal, .test.displayed .test-node.fatal, .test.displayed.fatal:not(.hasChildren)').length;
                                    warningTests = $('.details-container .test-node.warning, .test.displayed .test-node.warning, .test.displayed.warning:not(.hasChildren)').length;
                                    errorTests = $('.details-container .test-node.error, .test.displayed .test-node.error, .test.displayed.error:not(.hasChildren)').length;
                                    skippedTests = $('.details-container .test-node.skip, .test.displayed .test-node.skip, .test.displayed.skip:not(.hasChildren)').length;
                                    unknownTests = $('.details-container .test-node.unknown, .test.displayed .test-node.unknown, .test.displayed.unknown:not(.hasChildren)').length;
                
                                    if (el.hasClass('parentWithoutNodes')) {
                                        totalTests = $('.test.displayed').length;
                                        passedTests = $('.test.displayed.pass').length;
                                        failedTests = $('.test.displayed.fail').length;
                                        fatalTests = $('.test.displayed.fatal').length;
                                        warningTests = $('.test.displayed.warning').length;
                                        errorTests = $('.test.displayed.error').length;
                                        skippedTests = $('.test.displayed.skip').length;
                                        unknownTests = $('.test.displayed.unknown').length;
                                    }
                                    else if (el.hasClass('childNodes')) {
                                        totalTests = $('.test-node').length;
                                        passedTests = $('.test.displayed .test-node.pass, .details-container .test-node.pass').length;
                                        failedTests = $('.test.displayed .test-node.fail, .details-container .test-node.fail').length;
                                        fatalTests = $('.test.displayed .test-node.fatal, .details-container .test-node.fatal').length;
                                        warningTests = $('.test.displayed .test-node.warning, .details-container .test-node.warning').length;
                                        errorTests = $('.test.displayed .test-node.error, .details-container .test-node.error').length;
                                        skippedTests = $('.test.displayed .test-node.skip, .details-container .test-node.skip').length;
                                        unknownTests = $('.test.displayed .test-node.unknown, .details-container .test-node.unknown').length;
                                    }
                
                                    totalSteps = $('td.status').length;
                                    passedSteps = $('td.status.pass').length;
                                    failedSteps = $('td.status.fail').length;
                                    fatalSteps = $('td.status.fatal').length;
                                    warningSteps = $('td.status.warning').length;
                                    errorSteps = $('td.status.error').length;
                                    infoSteps = $('td.status.info').length;
                                    skippedSteps = $('td.status.skip').length;
                                    unknownSteps = $('td.status.unknown').length;
                
                                    $('.t-pass-count').text(passedTests);
                                    $('.t-fail-count').text(failedTests + fatalTests);
                                    $('.t-warning-count').text(warningTests);
                                    $('.t-fatal-count').text(fatalTests);
                                    $('.t-error-count').text(errorTests);
                                    $('.t-skipped-count').text(skippedTests);
                                    $('.t-others-count').text(warningTests + errorTests + skippedTests + unknownTests);
                
                                    var percentage = Math.round((passedTests * 100) / (passedTests + failedTests + fatalTests + warningTests + errorTests + unknownTests + skippedTests)) + '%';
                                    $('.pass-percentage.panel-lead').text(percentage);
                                    $('#dashboard-view .determinate').attr('style', 'width:' + percentage);
                
                                    if ($('#step-status-filter').hasClass('pass')) { passedSteps = 0; }
                                    if ($('#step-status-filter').hasClass('fail')) { failedSteps = 0; }
                                    if ($('#step-status-filter').hasClass('fatal')) { fatalSteps = 0; }
                                    if ($('#step-status-filter').hasClass('warning')) { warningSteps = 0; }
                                    if ($('#step-status-filter').hasClass('error')) { errorSteps = 0; }
                                    if ($('#step-status-filter').hasClass('info')) { infoSteps = 0; }
                                    if ($('#step-status-filter').hasClass('skip')){ skippedSteps = 0; }
                                    if ($('#step-status-filter').hasClass('unknown')) { unknownSteps = 0; }
                
                                    $('.s-pass-count').text(passedSteps);
                                    $('.s-fail-count').text(failedSteps + fatalSteps);
                                    $('.s-warning-count').text(warningSteps);
                                    $('.s-error-count').text(errorSteps);
                                    $('.s-skipped-count').text(skippedSteps);
                                    $('.s-others-count').text(warningSteps + errorSteps + skippedSteps + unknownSteps + infoSteps);
                                    $('.total-tests > .panel-lead').text(totalTests);
                                    $('.total-steps > .panel-lead').text(totalSteps);
                                }
            
                                /* dashboard chart options [DASHBOARD] */
                                var options = {
                                    segmentShowStroke : true, 
                                    segmentStrokeColor : '#eee', 
                                    segmentStrokeWidth : 1, 
                                    percentageInnerCutout : 55, 
                                    animationSteps : 30, 
                                    animationEasing : 'easeOutBounce', 
                                    animateRotate : true, 
                                    animateScale : false,
                                    legendTemplate : '<ul class=\'<%=name.toLowerCase()%>-legend\'><% for (var i=0; i<segments.length; i++){%><li><span style=\'background-color:<%=segments[i].fillColor%>\'></span><%if(segments[i].label){%><%=segments[i].label%><%}%></li><%}%></ul>'
                                };
            
                                /* tests view chart [DASHBOARD] */
                                function testsChart() {
                                    var data = [
                                        { value: passedTests, color: '#00af00', highlight: '#32bf32', label: 'Pass' },
                                        { value: failedTests, color:'#F7464A', highlight: '#FF5A5E', label: 'Fail' },
                                        { value: fatalTests, color:'#8b0000', highlight: '#a23232', label: 'Fatal' },
                                        { value: errorTests, color:'#ff6347', highlight: '#ff826b', label: 'Error' },
                                        { value: warningTests, color: '#FDB45C', highlight: '#FFC870', label: 'Warning' },
                                        { value: skippedTests, color: '#1e90ff', highlight: '#4aa6ff', label: 'Skip' },
                                        { value: unknownTests, color: '#222', highlight: '#444', label: 'Unknown' }
                                    ];
                    
                                    var ctx = $('#test-analysis').get(0).getContext('2d');
                                    testChart = new Chart(ctx).Doughnut(data, options);
                                    var legendHolder = drawLegend(testChart, 'test-analysis');
                                }
              
                                /* steps view chart [DASHBOARD] */
                                function stepsChart() {
                                    var data = [
                                        { value: passedSteps, color: '#00af00', highlight: '#32bf32', label: 'Pass' },
                                        { value: infoSteps, color: '#46BFBD', highlight: '#5AD3D1', label: 'Info' },
                                        { value: failedSteps, color:'#F7464A', highlight: '#FF5A5E', label: 'Fail' },
                                        { value: fatalSteps, color:'#8b0000', highlight: '#a23232', label: 'Fatal' },
                                        { value: errorSteps, color:'#ff6347', highlight: '#ff826b', label: 'Error' },
                                        { value: warningSteps, color: '#FDB45C', highlight: '#FFC870', label: 'Warning' },
                                        { value: skippedSteps, color: '#1e90ff', highlight: '#4aa6ff', label: 'Skip' },
                                        { value: unknownSteps, color: '#222', highlight: '#444', label: 'Unknown' }
                                    ];
                
                                    var ctx = $('#step-analysis').get(0).getContext('2d');
                                    stepChart = new Chart(ctx).Doughnut(data, options);
                                    drawLegend(stepChart, 'step-analysis');
                                }
            
                                /* draw legend for test and step charts [DASHBOARD] */
                                function drawLegend(chart, id) {
                                    var helpers = Chart.helpers;
                                    var legendHolder = document.getElementById(id);
                                    legendHolder.innerHTML = chart.generateLegend();
                
                                    helpers.each(legendHolder.firstChild.childNodes, function(legendNode, index) {
                                        helpers.addEvent(legendNode, 'mouseover', function() {
                                            var activeSegment = chart.segments[index];
                                            activeSegment.save();
                                            activeSegment.fillColor = activeSegment.highlightColor;
                                            chart.showTooltip([activeSegment]);
                                            activeSegment.restore();
                                        });
                                    });
                
                                    Chart.helpers.addEvent(legendHolder.firstChild, 'mouseout', function() {
                                        chart.draw();
                                    });
                                    $('#' + id).after(legendHolder.firstChild);
                               }
              
                               testsChart(); stepsChart();
                               $('ul.doughnut-legend').addClass('right');
                               redrawCharts();
              
                               $('#dashboard-view').addClass('hide');
                            </script>
                        </body>
                    </html>";//.Replace("    ", "").Replace("\t", "").Replace("\r", "").Replace("\n", "");
            }
        }
    }
}
