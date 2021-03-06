#pragma checksum "E:\Working\Nguyen\EasyWeb\EasyWeb\EasyWeb.Web\Areas\Administrator\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cf9f1861415cf8bd0916b63d741bb0b3c95ce7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Dashboard/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cf9f1861415cf8bd0916b63d741bb0b3c95ce7e", @"/Areas/Administrator/Views/Dashboard/Index.cshtml")]
    public class Areas_Administrator_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Working\Nguyen\EasyWeb\EasyWeb\EasyWeb.Web\Areas\Administrator\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index admin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-body"">
    <div class=""page-wrapper"">

        <div class=""page-body"">
            <div class=""row"">
                <!-- task, page, download counter  start -->
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card bg-c-yellow update-card"">
                        <div class=""card-block"">
                            <div class=""row align-items-end"">
                                <div class=""col-8"">
                                    <h4 class=""text-white"">$30200</h4>
                                    <h6 class=""text-white m-b-0"">All Earnings</h6>
                                </div>
                                <div class=""col-4 text-right"">
                                    <canvas id=""update-chart-1"" height=""50""></canvas>
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer"">
                            <p class=""text-white m-b-0");
            WriteLiteral(@"""><i class=""feather icon-clock text-white f-14 m-r-10""></i>update : 2:15 am</p>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card bg-c-green update-card"">
                        <div class=""card-block"">
                            <div class=""row align-items-end"">
                                <div class=""col-8"">
                                    <h4 class=""text-white"">290+</h4>
                                    <h6 class=""text-white m-b-0"">Page Views</h6>
                                </div>
                                <div class=""col-4 text-right"">
                                    <canvas id=""update-chart-2"" height=""50""></canvas>
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer"">
                            <p class=""text-white m-b-0""><i class=""feather icon-");
            WriteLiteral(@"clock text-white f-14 m-r-10""></i>update : 2:15 am</p>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card bg-c-pink update-card"">
                        <div class=""card-block"">
                            <div class=""row align-items-end"">
                                <div class=""col-8"">
                                    <h4 class=""text-white"">145</h4>
                                    <h6 class=""text-white m-b-0"">Task Completed</h6>
                                </div>
                                <div class=""col-4 text-right"">
                                    <canvas id=""update-chart-3"" height=""50""></canvas>
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer"">
                            <p class=""text-white m-b-0""><i class=""feather icon-clock text-white f-14 m");
            WriteLiteral(@"-r-10""></i>update : 2:15 am</p>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card bg-c-lite-green update-card"">
                        <div class=""card-block"">
                            <div class=""row align-items-end"">
                                <div class=""col-8"">
                                    <h4 class=""text-white"">500</h4>
                                    <h6 class=""text-white m-b-0"">Downloads</h6>
                                </div>
                                <div class=""col-4 text-right"">
                                    <canvas id=""update-chart-4"" height=""50""></canvas>
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer"">
                            <p class=""text-white m-b-0""><i class=""feather icon-clock text-white f-14 m-r-10""></i>update : 2:");
            WriteLiteral(@"15 am</p>
                        </div>
                    </div>
                </div>
                <!-- task, page, download counter  end -->
                <!--  sale analytics start -->
                <div class=""col-xl-9 col-md-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h5>Sales Analytics</h5>
                            <span class=""text-muted"">For more details about usage, please refer <a href=""https://www.amcharts.com/online-store/"" target=""_blank"">amCharts</a> licences.</span>
                            <div class=""card-header-right"">
                                <ul class=""list-unstyled card-option"">
                                    <li><i class=""feather icon-maximize full-card""></i></li>
                                    <li><i class=""feather icon-minus minimize-card""></i></li>
                                    <li><i class=""feather icon-trash-2 close-card""></i></li>
                  ");
            WriteLiteral(@"              </ul>
                            </div>
                        </div>
                        <div class=""card-block"">
                            <div id=""sales-analytics"" style=""height: 265px;""></div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-md-12"">
                    <div class=""card user-card2"">
                        <div class=""card-block text-center"">
                            <h6 class=""m-b-15"">Project Risk</h6>
                            <div class=""risk-rate"">
                                <span><b>5</b></span>
                            </div>
                            <h6 class=""m-b-10 m-t-10"">Balanced</h6>
                            <a href=""#!"" class=""text-c-yellow b-b-warning"">Change Your Risk</a>
                            <div class=""row justify-content-center m-t-10 b-t-default m-l-0 m-r-0"">
                                <div class=""col m-t-15 b-r-default"">
      ");
            WriteLiteral(@"                              <h6 class=""text-muted"">Nr</h6>
                                    <h6>AWS 2455</h6>
                                </div>
                                <div class=""col m-t-15"">
                                    <h6 class=""text-muted"">Created</h6>
                                    <h6>30th Sep</h6>
                                </div>
                            </div>
                        </div>
                        <button class=""btn btn-warning btn-block p-t-15 p-b-15"">Download Overall Report</button>
                    </div>
                </div>
                <!--  sale analytics end -->

                <div class=""col-xl-8 col-md-12"">
                    <div class=""card table-card"">
                        <div class=""card-header"">
                            <h5>Application Sales</h5>
                            <div class=""card-header-right"">
                                <ul class=""list-unstyled card-option"">
                  ");
            WriteLiteral(@"                  <li><i class=""feather icon-maximize full-card""></i></li>
                                    <li><i class=""feather icon-minus minimize-card""></i></li>
                                    <li><i class=""feather icon-trash-2 close-card""></i></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""card-block"">
                            <div class=""table-responsive"">
                                <table class=""table table-hover  table-borderless"">
                                    <thead>
                                        <tr>
                                            <th>
                                                <div class=""chk-option"">
                                                    <div class=""checkbox-fade fade-in-primary"">
                                                        <label class=""check-task"">
                                                            <");
            WriteLiteral("input type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 8262, "\"", 8270, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <span class=""cr"">
                                                                <i class=""cr-icon feather icon-check txt-default""></i>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </div>
                                                Application
                                            </th>
                                            <th>Sales</th>
                                            <th>Change</th>
                                            <th>Avg Price</th>
                                            <th>Total</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                              ");
            WriteLiteral(@"              <td>
                                                <div class=""chk-option"">
                                                    <div class=""checkbox-fade fade-in-primary"">
                                                        <label class=""check-task"">
                                                            <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 9652, "\"", 9660, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <span class=""cr"">
                                                                <i class=""cr-icon feather icon-check txt-default""></i>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </div>
                                                <div class=""d-inline-block align-middle"">
                                                    <h6>Able Pro</h6>
                                                    <p class=""text-muted m-b-0"">Powerful Admin Theme</p>
                                                </div>
                                            </td>
                                            <td>16,300</td>
                                            <td><canvas id=""app-sale1"" height=""50"" width=""100""></canvas></td>
                        ");
            WriteLiteral(@"                    <td>$53</td>
                                            <td class=""text-c-blue"">$15,652</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class=""chk-option"">
                                                    <div class=""checkbox-fade fade-in-primary"">
                                                        <label class=""check-task"">
                                                            <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 11281, "\"", 11289, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <span class=""cr"">
                                                                <i class=""cr-icon feather icon-check txt-default""></i>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </div>
                                                <div class=""d-inline-block align-middle"">
                                                    <h6>Photoshop</h6>
                                                    <p class=""text-muted m-b-0"">Design Software</p>
                                                </div>
                                            </td>
                                            <td>26,421</td>
                                            <td><canvas id=""app-sale2"" height=""50"" width=""100""></canvas></td>
                            ");
            WriteLiteral(@"                <td>$35</td>
                                            <td class=""text-c-blue"">$18,785</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class=""chk-option"">
                                                    <div class=""checkbox-fade fade-in-primary"">
                                                        <label class=""check-task"">
                                                            <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 12906, "\"", 12914, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <span class=""cr"">
                                                                <i class=""cr-icon feather icon-check txt-default""></i>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </div>
                                                <div class=""d-inline-block align-middle"">
                                                    <h6>Guruable</h6>
                                                    <p class=""text-muted m-b-0"">Best Admin Template</p>
                                                </div>
                                            </td>
                                            <td>8,265</td>
                                            <td><canvas id=""app-sale3"" height=""50"" width=""100""></canvas></td>
                          ");
            WriteLiteral(@"                  <td>$98</td>
                                            <td class=""text-c-blue"">$9,652</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class=""chk-option"">
                                                    <div class=""checkbox-fade fade-in-primary"">
                                                        <label class=""check-task"">
                                                            <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 14532, "\"", 14540, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <span class=""cr"">
                                                                <i class=""cr-icon feather icon-check txt-default""></i>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </div>
                                                <div class=""d-inline-block align-middle"">
                                                    <h6>Flatable</h6>
                                                    <p class=""text-muted m-b-0"">Admin App</p>
                                                </div>
                                            </td>
                                            <td>10,652</td>
                                            <td><canvas id=""app-sale4"" height=""50"" width=""100""></canvas></td>
                                   ");
            WriteLiteral(@"         <td>$20</td>
                                            <td class=""text-c-blue"">$7,856</td>
                                        </tr>
                                    </tbody>
                                </table>
                                <div class=""text-center"">
                                    <a href=""#!"" class="" b-b-primary text-primary"">View all Projects</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-4 col-md-12"">
                    <div class=""card user-activity-card"">
                        <div class=""card-header"">
                            <h5>User Activity</h5>
                        </div>
                        <div class=""card-block"">
                            <div class=""row m-b-25"">
                                <div class=""col-auto p-r-0"">
                                    <div class=""u-");
            WriteLiteral(@"img"">
                                        <img src=""..\files\assets\images\breadcrumb-bg.jpg"" alt=""user image"" class=""img-radius cover-img"">
                                        <img src=""..\files\assets\images\avatar-2.jpg"" alt=""user image"" class=""img-radius profile-img"">
                                    </div>
                                </div>
                                <div class=""col"">
                                    <h6 class=""m-b-5"">John Deo</h6>
                                    <p class=""text-muted m-b-0"">Lorem Ipsum is simply dummy text.</p>
                                    <p class=""text-muted m-b-0""><i class=""feather icon-clock m-r-10""></i>2 min ago</p>
                                </div>
                            </div>
                            <div class=""row m-b-25"">
                                <div class=""col-auto p-r-0"">
                                    <div class=""u-img"">
                                        <img src=""..\files\asset");
            WriteLiteral(@"s\images\breadcrumb-bg.jpg"" alt=""user image"" class=""img-radius cover-img"">
                                        <img src=""..\files\assets\images\avatar-2.jpg"" alt=""user image"" class=""img-radius profile-img"">
                                    </div>
                                </div>
                                <div class=""col"">
                                    <h6 class=""m-b-5"">John Deo</h6>
                                    <p class=""text-muted m-b-0"">Lorem Ipsum is simply dummy text.</p>
                                    <p class=""text-muted m-b-0""><i class=""feather icon-clock m-r-10""></i>2 min ago</p>
                                </div>
                            </div>
                            <div class=""row m-b-25"">
                                <div class=""col-auto p-r-0"">
                                    <div class=""u-img"">
                                        <img src=""..\files\assets\images\breadcrumb-bg.jpg"" alt=""user image"" class=""img-radius cover-im");
            WriteLiteral(@"g"">
                                        <img src=""..\files\assets\images\avatar-2.jpg"" alt=""user image"" class=""img-radius profile-img"">
                                    </div>
                                </div>
                                <div class=""col"">
                                    <h6 class=""m-b-5"">John Deo</h6>
                                    <p class=""text-muted m-b-0"">Lorem Ipsum is simply dummy text.</p>
                                    <p class=""text-muted m-b-0""><i class=""feather icon-clock m-r-10""></i>2 min ago</p>
                                </div>
                            </div>
                            <div class=""row m-b-5"">
                                <div class=""col-auto p-r-0"">
                                    <div class=""u-img"">
                                        <img src=""..\files\assets\images\breadcrumb-bg.jpg"" alt=""user image"" class=""img-radius cover-img"">
                                        <img src=""..\files\assets\i");
            WriteLiteral(@"mages\avatar-2.jpg"" alt=""user image"" class=""img-radius profile-img"">
                                    </div>
                                </div>
                                <div class=""col"">
                                    <h6 class=""m-b-5"">John Deo</h6>
                                    <p class=""text-muted m-b-0"">Lorem Ipsum is simply dummy text.</p>
                                    <p class=""text-muted m-b-0""><i class=""feather icon-clock m-r-10""></i>2 min ago</p>
                                </div>
                            </div>

                            <div class=""text-center"">
                                <a href=""#!"" class=""b-b-primary text-primary"">View all Projects</a>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- wather user -->
                <div class=""col-xl-6 col-md-12"">
                    <div class=""card latest-update-card"">
                        ");
            WriteLiteral(@"<div class=""card-header"">
                            <h5>Latest Updates</h5>
                            <div class=""card-header-right"">
                                <ul class=""list-unstyled card-option"">
                                    <li><i class=""fa fa fa-wrench open-card-option""></i></li>
                                    <li><i class=""fa fa-window-maximize full-card""></i></li>
                                    <li><i class=""fa fa-minus minimize-card""></i></li>
                                    <li><i class=""fa fa-refresh reload-card""></i></li>
                                    <li><i class=""fa fa-trash close-card""></i></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""card-block"">
                            <div class=""latest-update-box"">
                                <div class=""row p-b-15"">
                                    <div class=""col-auto text-right update-meta"">
  ");
            WriteLiteral(@"                                      <p class=""text-muted m-b-0 d-inline"">4 hrs ago</p>
                                        <i class=""feather icon-briefcase bg-simple-c-pink update-icon""></i>
                                    </div>
                                    <div class=""col"">
                                        <h6>+ 5 New Products were added!</h6>
                                        <p class=""text-muted m-b-0"">Congratulations!</p>
                                    </div>
                                </div>
                                <div class=""row p-b-15"">
                                    <div class=""col-auto text-right update-meta"">
                                        <p class=""text-muted m-b-0 d-inline"">1 day ago</p>
                                        <i class=""feather icon-check bg-simple-c-yellow  update-icon""></i>
                                    </div>
                                    <div class=""col"">
                                 ");
            WriteLiteral(@"       <h6>Database backup completed!</h6>
                                        <p class=""text-muted m-b-0"">Download the <span class=""text-c-blue"">latest backup</span>.</p>
                                    </div>
                                </div>
                                <div class=""row p-b-0"">
                                    <div class=""col-auto text-right update-meta"">
                                        <p class=""text-muted m-b-0 d-inline"">2 day ago</p>
                                        <i class=""feather icon-facebook bg-simple-c-green update-icon""></i>
                                    </div>
                                    <div class=""col"">
                                        <h6>+1 Friend Requests</h6>
                                        <p class=""text-muted m-b-10"">This is great, keep it up!</p>
                                        <div class=""table-responsive"">
                                            <table class=""table table-hover m-b-");
            WriteLiteral(@"0"">
                                                <tbody>
                                                    <tr>
                                                        <td class=""b-none"">
                                                            <a href=""#!"" class=""align-middle"">
                                                                <img src=""..\files\assets\images\avatar-2.jpg"" alt=""user image"" class=""img-radius img-40 align-top m-r-15"">
                                                                <div class=""d-inline-block"">
                                                                    <h6>Jeny William</h6>
                                                                    <p class=""text-muted m-b-0"">Graphic Designer</p>
                                                                </div>
                                                            </a>
                                                        </td>
                                                    </");
            WriteLiteral(@"tr>
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""text-center"">
                                <a href=""#!"" class=""b-b-primary text-primary"">View all Projects</a>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-xl-6 col-md-12"">
                    <div class=""card user-card-full"">
                        <div class=""row m-l-0 m-r-0"">
                            <div class=""col-sm-4 bg-c-lite-green user-profile"">
                                <div class=""card-block text-center text-white"">
                                    <div class=""m-b-25"">
                                        <img src=""..\files\assets\images\avatar-4");
            WriteLiteral(@".jpg"" class=""img-radius"" alt=""User-Profile-Image"">
                                    </div>
                                    <h6 class=""f-w-600"">Jeny William</h6>
                                    <p>Web Designer</p>
                                    <i class=""feather icon-edit m-t-10 f-16""></i>
                                </div>
                            </div>
                            <div class=""col-sm-8"">
                                <div class=""card-block"">
                                    <h6 class=""m-b-20 p-b-5 b-b-default f-w-600"">Information</h6>
                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <p class=""m-b-10 f-w-600"">Email</p>
                                            <h6 class=""text-muted f-w-400""><a href=""..\..\..\cdn-cgi\l\email-protection.htm"" class=""__cf_email__"" data-cfemail=""1379767d6a53747e727a7f3d707c7e"">[email&#160;protected]</a></h6>
   ");
            WriteLiteral(@"                                     </div>
                                        <div class=""col-sm-6"">
                                            <p class=""m-b-10 f-w-600"">Phone</p>
                                            <h6 class=""text-muted f-w-400"">0023-333-526136</h6>
                                        </div>
                                    </div>
                                    <h6 class=""m-b-20 m-t-40 p-b-5 b-b-default f-w-600"">Projects</h6>
                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <p class=""m-b-10 f-w-600"">Recent</p>
                                            <h6 class=""text-muted f-w-400"">Guruable Admin</h6>
                                        </div>
                                        <div class=""col-sm-6"">
                                            <p class=""m-b-10 f-w-600"">Most Viewed</p>
                                            <h");
            WriteLiteral(@"6 class=""text-muted f-w-400"">Able Pro Admin</h6>
                                        </div>
                                    </div>
                                    <ul class=""social-link list-unstyled m-t-40 m-b-10"">
                                        <li><a href=""#!"" data-toggle=""tooltip"" data-placement=""bottom""");
            BeginWriteAttribute("title", " title=\"", 28187, "\"", 28195, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"facebook\"><i class=\"feather icon-facebook facebook\" aria-hidden=\"true\"></i></a></li>\r\n                                        <li><a href=\"#!\" data-toggle=\"tooltip\" data-placement=\"bottom\"");
            BeginWriteAttribute("title", " title=\"", 28406, "\"", 28414, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"twitter\"><i class=\"feather icon-twitter twitter\" aria-hidden=\"true\"></i></a></li>\r\n                                        <li><a href=\"#!\" data-toggle=\"tooltip\" data-placement=\"bottom\"");
            BeginWriteAttribute("title", " title=\"", 28622, "\"", 28630, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-original-title=""instagram""><i class=""feather icon-instagram instagram"" aria-hidden=""true""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- wather user -->
                <!-- social download  start -->
                <div class=""col-xl-4 col-md-6"">
                    <div class=""card social-card bg-simple-c-blue"">
                        <div class=""card-block"">
                            <div class=""row align-items-center"">
                                <div class=""col-auto"">
                                    <i class=""feather icon-mail f-34 text-c-blue social-icon""></i>
                                </div>
                                <div class=""col"">
                                    <h6 class=""m-b-0"">Mail</h6>
                                    <p>231.2w downloads</p>
                ");
            WriteLiteral(@"                    <p class=""m-b-0"">Lorem Ipsum is simply dummy text of the printing</p>
                                </div>
                            </div>
                        </div>
                        <a href=""#!"" class=""download-icon""><i class=""feather icon-arrow-down""></i></a>
                    </div>
                </div>
                <div class=""col-xl-4 col-md-6"">
                    <div class=""card social-card bg-simple-c-pink"">
                        <div class=""card-block"">
                            <div class=""row align-items-center"">
                                <div class=""col-auto"">
                                    <i class=""feather icon-twitter f-34 text-c-pink social-icon""></i>
                                </div>
                                <div class=""col"">
                                    <h6 class=""m-b-0"">twitter</h6>
                                    <p>231.2w downloads</p>
                                    <p class=""m-b-0"">Lor");
            WriteLiteral(@"em Ipsum is simply dummy text of the printing</p>
                                </div>
                            </div>
                        </div>
                        <a href=""#!"" class=""download-icon""><i class=""feather icon-arrow-down""></i></a>
                    </div>
                </div>
                <div class=""col-xl-4 col-md-12"">
                    <div class=""card social-card bg-simple-c-green"">
                        <div class=""card-block"">
                            <div class=""row align-items-center"">
                                <div class=""col-auto"">
                                    <i class=""feather icon-instagram f-34 text-c-green social-icon""></i>
                                </div>
                                <div class=""col"">
                                    <h6 class=""m-b-0"">Instagram</h6>
                                    <p>231.2w downloads</p>
                                    <p class=""m-b-0"">Lorem Ipsum is simply dummy text of ");
            WriteLiteral(@"the printing</p>
                                </div>
                            </div>
                        </div>
                        <a href=""#!"" class=""download-icon""><i class=""feather icon-arrow-down""></i></a>
                    </div>
                </div>
                <!-- social download  end -->

            </div>
        </div>
    </div>

    <div id=""styleSelector"">

    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
