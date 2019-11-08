import { Component, OnInit } from '@angular/core';
import { Hero } from '../hero';
import { HEROES } from '../mock-heroes';
import {
  trigger,state,style,animate,transition, stagger, query
} from '@angular/animations';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css'],
  animations:[
    trigger('openClose', [
      // state('open',style({
      //   height: '200px',
      //   opacity: 0.5,
      //   backgroundColor: 'yellow'
      // })),
      // state('close', style({
      //   height: '100px',
      //   opacity: 1,
      //   backgroundColor: 'green'
      // })),
      // transition('open<=>close',[
      //   animate('2s ease-out')
      // ]),
      transition('* <=> *',[
        query(':leave',[
          stagger(50,[
            style({ opacity: 1 }),
            animate('1s 100ms ease-in-out', style({
              height: '50px',
              opacity: 0.9,
              backgroundColor: 'green'
            })),
            animate('1s 100ms ease-in-out', style({
              height: '0px',
              opacity: 0,
              backgroundColor: 'yellow'
            })),
          ]),
          state('test',style({
            width:'100px'
          })),
        ],{optional: true}),
        
        query(':enter',[
          style({ opacity: 0 }),
          stagger(100,[
            animate('0.5s ease-out', style({
              height: '100px',
              opacity: 1,
              //backgroundColor: 'green'
            })),
            animate('0.5s ease-in-out', style({
              height: '1.6em',
              opacity: 1,
              //backgroundColor: 'green'
            })),

          ]),

        ],{optional: true})
      ]),
    ]),
  ]
})
export class HeroesComponent implements OnInit {

  selectedHero: Hero;
  onSelect(hero: Hero): void{
    this.selectedHero = hero;
    //this.openToggle();
  }
  isOpen: boolean = true;
  heroes: Hero[] = [];
  animState = "";

  openToggle(){
    this.isOpen = !this.isOpen;
    if (this.isOpen){
      this.animState = 'open';
      this.heroes = HEROES;
    } else {
      this.heroes = [];
      this.animState = 'close'
    }
  }


  constructor() { }

  ngOnInit() {
  }

}

