import { Component } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent {
  public EmployeeID:number=54654564;
  public EmployeeName:string="Stephen";
  public Empjob:string="Manager";
  public Empsalary:number=75000;
  public EmpDepo:number=10;

}
