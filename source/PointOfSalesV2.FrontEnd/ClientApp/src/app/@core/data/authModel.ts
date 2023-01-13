import { User } from './users';

export class AuthModel {
    status: number = -1;
    token: string = '';
    expiration: Date;
  email: string = '';
  xApiKey: string = '';
    password: string = '';
    user: User = null;
    languageId: string = '';
}
