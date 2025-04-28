pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git url: 'https://github.com/jrtanjr0218/github-actions-for-desktop-apps.git', branch: 'main'
            }
        }
        stage('Gradle Restore') {
            steps {
                bat 'gradle restore'
            }
        }
        stage('Build WPF App') {
            steps {
                bat 'gradle buildDotnet'
            }
        }
        stage('Execute Unit Tests') {
            steps {
                bat 'gradle testDotnet'
            }
        }
        stage('Publish WPF App') {
            steps {
                bat 'gradle publishDotnet'
            }
        }
        stage('Build Docker Image') {
            steps {
                bat 'docker build -t mywpfapp .'
            }
        }
        stage('Run Docker Image') {
            steps {
                bat 'docker run --rm mywpfapp'
            }
        }
    }
}
