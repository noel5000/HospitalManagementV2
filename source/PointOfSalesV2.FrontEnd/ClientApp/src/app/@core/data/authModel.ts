import { User } from './users';

export class AuthModel {
    status: number = -1;
    token: string = '';
    expiration: Date = new Date();
  email: string = '';
    password: string = '';
    user: User | null = null;
    languageId: string = '';
}
