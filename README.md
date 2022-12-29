### API Endpoints

1 **/register** endpoint for creating new users
- user registers with email and password
- **User Model**:
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

3 **/status** endpoint for creating and retrieving status
- GET: Get latest 10 statuses of all users except logged in user
- POST: Create new status for user
- **Status Model**:
```json
    {
        id: guid // Primary Key
        email: string // Foreign Key
        content: string
        createdAt: Date
        updatedAt: Date
    }
```

4 **/status/{id}**
- CRUD Operations on a single status

All users are friends by default