import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { AdvertismentService } from 'src/app/services/advertisment.service';
import { WrapperFuncService } from 'src/app/services/wrapper-func.service';
import { MessageService as ToastService } from 'primeng/api';
import { ScoringAction, ScoringService, ScroingOperationVM } from 'src/app/services/Scoring.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-system-operition-form',
  templateUrl: './system-operition-form.component.html',
  styleUrls: ['./system-operition-form.component.css']
})
export class SystemOperitionFormComponent implements OnInit 
{

  constructor(
    public _funcService: WrapperFuncService,
    private _scoringService: ScoringService,
    public _toast: ToastService
  ) { }
  // operitionId;
  @Output() closed = new EventEmitter();
  @Output() Output = new EventEmitter();
  scoringAction :ScoringAction;
  scoringOperitinsList :ScroingOperationVM[]= [];
  scoringOperitinsListAfterFilter :ScroingOperationVM[]= null;
  operition : ScroingOperationVM = {} as ScroingOperationVM;
  newOperition ;
  formUpdate: FormGroup = new FormGroup({
   ActionName : new FormControl({value:'',disabled: true}),
   Count: new FormControl({value:'',disabled: true}),
   FromDate: new FormControl(),
   TillDate: new FormControl(),
});
formCreate: FormGroup = new FormGroup({
    ActionName : new FormControl('', [Validators.required]),
    Count: new FormControl(),
    FromDate: new FormControl(),
    TillDate: new FormControl(),
});

  ngOnInit(): void {
   this._scoringService.getScroingOperation(2).subscribe(res=>{
      this.scoringOperitinsList = res;
      this.scoringOperitinsList.map((obj)=>{
         if(this.scoringOperitinsListAfterFilter == null){
          this.scoringOperitinsListAfterFilter=[];
           this.scoringOperitinsListAfterFilter.push(obj);
          }
        else{
         var op= this.scoringOperitinsListAfterFilter.find(x=>x.ActionId == obj.ActionId);
         if(op == undefined){
          this.scoringOperitinsListAfterFilter.push(obj);
         }
        }
      });
   });
   console.log("scoringOperitinsList",this.scoringOperitinsListAfterFilter);
   if(this.operition)
   {
      console.log("operition",this.operition);
      this.formUpdate.patchValue({
        ActionName:this.operition.ScoringAction.ActionName,
        Count:this.operition.Count ,
        FromDate:this.operition.FromDate? new Date(this.operition.FromDate): null ,
        TillDate: this.operition.TillDate? new Date(this.operition.TillDate): null
      });
    }
  }

  submitFormUpdate(){
    if(this.formUpdate.valid){
      if(this.operition){
         let formValue = this.formUpdate.value;
         this.operition.FromDate= formValue.FromDate;
         this.operition.TillDate = formValue.TillDate;
         console.log("this.operitin",this.operition);
         this._scoringService.updateScroingOperation(this.operition)
         .subscribe((res: boolean) => {
          console.log("true or false",res);
          Swal.fire('פרטי הפעולה נשמרו במערכת').then((_val)=>{
            this.closed.emit(this.operition);
            this._funcService.closeDialog();
          });
        });
      }
    }
  }
  onChange(newValue) {
    this.scoringAction = newValue.ScoringAction;
}
  submitFormCreate(){
    if(this.formCreate.valid){      
      this.newOperition = {} as ScroingOperationVM;
      let formValue = this.formCreate.value;
      console.log("idaction",formValue.ActionName);
      this.newOperition.ActionId = this.scoringAction.Id;
      this.newOperition.Count= Number(formValue.Count);
      this.newOperition.FromDate=formValue.FromDate;
      this.newOperition.TillDate=formValue.TillDate;      
      this._scoringService.createScroingOperation(this.newOperition).subscribe(res =>{
        let mm :ScoringAction = {
          ActionName : this.scoringAction.ActionName,
          EventTypeId :2,
          Id : this.newOperition.ActionId
         }
         let newop: ScroingOperationVM = {
          Id :this.newOperition.ActionId,
          Count : this.newOperition.Count,
          FromDate :this.newOperition.FromDate,
          TillDate :this.newOperition.TillDate,
          ActionId : this.newOperition.ActionId,
          ScoringAction :mm
         };
           Swal.fire('פרטי המוצר נשמרו במערכת').then((val)=>{
             this.closed.emit(newop);
             this._funcService.closeDialog();
             console.log("newop",newop);
        });

      }
      )
      
    }
  }
   close(){
      this._funcService.closeDialog();
   }
}
