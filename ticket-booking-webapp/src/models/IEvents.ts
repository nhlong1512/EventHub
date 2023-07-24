import { ICategory } from './ICategory';


export interface IEvent{ 
    id: string;
    image: string;
    title: string;
    minPrice: number;
    date: string;
    location: string;
    city: string;
    status: number;
    categories: ICategory[];
}