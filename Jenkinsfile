pipeline {
  agent any
  stages {
    stage('Mensagem') {
      steps {
        echo 'Pipeline rodando'
        mail(subject: '[Jenkins] Pipeline - BodyOn', body: 'Pipeline foi iniciado, este � um email de verifica��o.', to: 'ewaldoj18@gmail.com, marianaoliveirafernandes11@gmail.com')
      }
    }

  }
}