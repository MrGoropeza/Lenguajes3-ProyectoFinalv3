<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalendarioSelect.ascx.cs" Inherits="Lenguajes3_ProyectoFinalv3.Pages.Widgets.CalendarioSelect" %>

<div class="row">
    <div class="book-calendar-grid">
        <div class="book-calendar">
            <table class="table">
                <thead>
                    <tr>
                        <td colspan="7">
                            <h2>May
                                <a href="#" class="arrows"><i class="fa fa-angle-double-right"></i></a>
                            </h2>
                        </td>
                    </tr>
                    <tr class="days">
                        <th>SUN</th>
                        <th>MON</th>
                        <th>TUE</th>
                        <th>WED</th>
                        <th>THU</th>
                        <th>FRI</th>
                        <th>SAT</th>
                    </tr>
                </thead>
                <tbody>
                    <tr class="passdate">
                        <td class="nextmonth">30</td>
                        <td title="No Available">1</td>
                        <td title="No Available">2</td>
                        <td title="No Available">3</td>
                        <td title="No Available">4</td>
                        <td title="No Available">5</td>
                        <td title="No Available">6</td>
                    </tr>
                    <tr class="passdate">
                        <td title="No Available">7</td>
                        <td title="No Available">8</td>
                        <td title="No Available">9</td>
                        <td title="No Available">10</td>
                        <td title="No Available">11</td>
                        <td title="No Available">12</td>
                        <td class="passdate">13</td>
                    </tr>
                    <tr>
                        <td class="passdate">14</td>
                        <td class="passdate">15</td>
                        <td class="passdate">16</td>
                        <td>17</td>
                        <td><span class="date-numer" id="2" data-toggle="tooltip" data-placement="top" title="¡Available!">18</span></td>
                        <td><span class="date-numer" id="3" data-toggle="tooltip" data-placement="top" title="¡Available!">19</span></td>
                        <td><span class="date-numer" id="4" data-toggle="tooltip" data-placement="top" title="¡Available!">20</span></td>
                    </tr>
                    <tr class="list-available" id="list-book-2">
                        <td colspan="7" class="booked-list">
                            <span class="close"><i class="fa fa-times-circle"></i></span>
                            <h4>Available Appointments on February 18, 2017</h4>
                            <div class="row">
                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>8:00 - 8:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>8:30 - 8:50</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>10:00 - 10:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>10:30 - 10:50</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>11:30 - 11:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>13:00 - 13:20</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>14:00 - 14:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>14:30 - 14:50</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>15:30 - 15:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>16:00 - 16:20</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>17:00 - 17:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>17:30 - 17:50</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <span data-toggle="modal" data-target=".modal" class="btn btn-xsmall">book appointment</span>
                            </div>
                        </td>
                    </tr>
                    <tr class="list-available" id="list-book-3">
                        <td colspan="7" class="booked-list">
                            <span class="close"><i class="fa fa-times-circle"></i></span>
                            <h4>Available Appointments on February 19, 2017</h4>
                            <div class="row">
                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>8:00 - 8:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>8:30 - 8:50</span>
                                        </label>
                                    </div>


                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>9:30 - 9:50</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>10:00 - 10:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>10:30 - 10:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>11:00 - 11:20</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>11:30 - 11:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>13:00 - 13:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>13:30 - 13:50</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>14:00 - 14:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>14:30 - 14:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>15:00 - 15:20</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>15:30 - 15:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>16:00 - 16:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>16:30 - 16:50</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>17:00 - 17:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>17:30 - 17:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>18:00 - 18:20</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <a href="#" class="btn btn-xsmall">book appointment</a>
                            </div>
                        </td>
                    </tr>
                    <tr class="list-available" id="list-book-4">
                        <td colspan="7" class="booked-list">
                            <span class="close"><i class="fa fa-times-circle"></i></span>
                            <h4>Available Appointments on February 19, 2017</h4>
                            <div class="row">
                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>8:00 - 8:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>8:30 - 8:50</span>
                                        </label>
                                    </div>


                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>9:30 - 9:50</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>10:00 - 10:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>10:30 - 10:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>11:00 - 11:20</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>11:30 - 11:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>13:00 - 13:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>13:30 - 13:50</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>14:00 - 14:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>14:30 - 14:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>15:00 - 15:20</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>15:30 - 15:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>16:00 - 16:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>16:30 - 16:50</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <!--List Book-->
                                <div class="time-book">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>17:00 - 17:20</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>17:30 - 17:50</span>
                                        </label>
                                    </div>

                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="optionsRadios" value="option2">
                                            <span>18:00 - 18:20</span>
                                        </label>
                                    </div>
                                </div>
                                <!--List Book-->

                                <a href="#" class="btn btn-xsmall">book appointment</a>
                            </div>
                        </td>
                    </tr>

                    <tr>
                        <td>21</td>
                        <td>22</td>
                        <td>23</td>
                        <td>24</td>
                        <td>25</td>
                        <td>26</td>
                        <td>27</td>
                    </tr>
                    <tr>
                        <td>28</td>
                        <td>29</td>
                        <td>30</td>
                        <td>31</td>
                        <td class="nextmonth">1</td>
                        <td class="nextmonth">2</td>
                        <td class="nextmonth">3</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
