import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Button, Header, List } from 'semantic-ui-react';

function App() {
    const [activities, setActivities] = useState([])

    useEffect(() => {
        axios.get('http://localhost:5000/api/activities')
            .then(res => setActivities(res.data))
    }, [])

    return (
        <div>
            <Header as='h2' icon="users" content="Reactivities"></Header>
            <List>
                {activities.map((item : any) => {
                    return <List.Item key={item.id}>{item.title}</List.Item>
                })}
            </List>
            <Button content="test" />
        </div>
    );
}

export default App;
