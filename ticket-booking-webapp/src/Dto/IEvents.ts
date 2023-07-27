import { ICategory } from './ICategory';
import { ISeatEvent } from './ISeat';


export interface IEvent{ 
    id: string;
    image: string;
    title: string;
    minPrice: number;
    date: string;
    location: string;
    city: string;
    status: number;
    stageName: string;
    duration: string;
    categories: ICategory[];
    seatEvents: ISeatEvent[];
}