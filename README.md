### API Endpoints

1 **/register** endpoint for creating new users
- user registers with email and password
- User Model:
```json
    {
        email: string // Primary Key
        firstName: string
        lastName: string
        passWord: string
    }
```

2 **/login** endpoint for logging (with JWT)
- user logs in with email and password

3 **/status** endpoint for retrieving all statuses

4 **/status/{id}**
- CRUD Operations on a single status
- Status Model:
```json
    {
        id: guid // Primary Key
        content: string
        createdAt: Date
        updatedAt: Date
    }
```

All users are friends by default