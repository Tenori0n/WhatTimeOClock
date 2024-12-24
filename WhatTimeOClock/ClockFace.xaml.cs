using System.Diagnostics;

namespace WhatTimeOClock;

public partial class ClockFace : ContentView
{ 
    public ClockFace()
	{
		InitializeComponent();
        CreateClock();
        SetTime();
        StartClock();
    }
    async Task StartClock()
    {
        PeriodicTimer Clock = new PeriodicTimer(TimeSpan.FromSeconds(1));
        while (await Clock.WaitForNextTickAsync())
        {
            this.UpdateTime();
        }
    }
    void CreateClock()
    {
        Oclock12.RotateTo(0);
        Min1.RotateTo(6);
        Min2.RotateTo(12);
        Min3.RotateTo(18);
        Min4.RotateTo(24);
        Oclock1.RotateTo(30);
        Min6.RotateTo(36);
        Min7.RotateTo(42);
        Min8.RotateTo(48);
        Min9.RotateTo(54);
        Oclock2.RotateTo(60);
        Min11.RotateTo(66);
        Min12.RotateTo(72);
        Min13.RotateTo(78);
        Min14.RotateTo(84);
        Oclock3.RotateTo(90);
        Min16.RotateTo(96);
        Min17.RotateTo(102);
        Min18.RotateTo(108);
        Min19.RotateTo(114);
        Oclock4.RotateTo(120);
        Min21.RotateTo(126);
        Min22.RotateTo(132);
        Min23.RotateTo(138);
        Min24.RotateTo(144);
        Oclock5.RotateTo(150);
        Min26.RotateTo(156);
        Min27.RotateTo(162);
        Min28.RotateTo(168);
        Min29.RotateTo(174);
        Oclock6.RotateTo(180);
        Min31.RotateTo(186);
        Min32.RotateTo(192);
        Min33.RotateTo(198);
        Min34.RotateTo(204);
        Oclock7.RotateTo(210);
        Min36.RotateTo(216);
        Min37.RotateTo(222);
        Min38.RotateTo(228);
        Min39.RotateTo(234);
        Oclock8.RotateTo(240);
        Min41.RotateTo(246);
        Min42.RotateTo(252);
        Min43.RotateTo(258);
        Min44.RotateTo(264);
        Oclock9.RotateTo(270);
        Min46.RotateTo(276);
        Min47.RotateTo(282);
        Min48.RotateTo(288);
        Min49.RotateTo(294);
        Oclock10.RotateTo(300);
        Min51.RotateTo(306);
        Min52.RotateTo(312);
        Min53.RotateTo(318);
        Min54.RotateTo(324);
        Oclock11.RotateTo(330);
        Min56.RotateTo(336);
        Min57.RotateTo(342);
        Min58.RotateTo(348);
        Min59.RotateTo(354);
    }
    void SetTime()
    {
        DateTime now = DateTime.Now;
        SecondsLine.RotateTo(now.Second*6);
        MinutesLine.RotateTo(now.Minute*6+(now.Second/10));
        HoursLine.RotateTo(now.Hour*30+(now.Minute/2));
    }
    void UpdateTime()
    {
        SecondsLine.RelRotateTo(6);
        MinutesLine.RelRotateTo(0.1);
        HoursLine.RelRotateTo(0.0083333333);
    }
}