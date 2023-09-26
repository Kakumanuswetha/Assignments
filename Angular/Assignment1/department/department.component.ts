import { Component } from '@angular/core';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.css']
})
export class DepartmentComponent {
  public deptarray:any[]=[
    {Deptno:10,Dname:"Accounts",Loc:"Hyd"},
    {Deptno:20,Dname:"Sales",Loc:"Pune"},
    {Deptno:30,Dname:"Marketing",Loc:"Hyd"},
    {Deptno:40,Dname:"Operations",Loc:"Pune"},
    {Deptno:10,Dname:"Accounts",Loc:"Hyd"},
    {Deptno:20,Dname:"Sales",Loc:"Pune"},
    {Deptno:30,Dname:"Marketing",Loc:"Hyd"},
    {Deptno:40,Dname:"Operations",Loc:"Pune"},
    {Deptno:50,Dname:"Operations",Loc:"Pune"}

  ];
}
