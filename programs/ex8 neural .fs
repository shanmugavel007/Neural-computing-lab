[System]
Name='ex8 neural '
Type='mamdani'
Version=2.0
NumInputs=2
NumOutputs=1
NumRules=3
AndMethod='min'
OrMethod='max'
ImpMethod='min'
AggMethod='max'
DefuzzMethod='centroid'

[Input1]
Name='temperature'
Range=[0 110]
NumMFs=4
MF1='freezing':'trapmf',[0 0 30 50]
MF2='cool':'trimf',[30 50 70]
MF3='warm':'trimf',[50 70 90]
MF4='hot':'trapmf',[70 90 110 110]

[Input2]
Name='cloud_cover'
Range=[0 100]
NumMFs=3
MF1='sunny':'trapmf',[0 0 20 40]
MF2='party_cloud':'trimf',[20 50 80]
MF3='Overcast':'trapmf',[58.1813756613757 90.1813756613757 98.1813756613757 130.161375661376]

[Output1]
Name='speed'
Range=[0 100]
NumMFs=2
MF1='slow':'trapmf',[0 0 25 75]
MF2='fast':'trapmf',[25 75 100 100]

[Rules]
3 1, 2 (1) : 1
2 2, 1 (1) : 1
1 1, 2 (1) : 1
